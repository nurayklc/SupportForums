using Microsoft.AspNetCore.Mvc;
using SupportForum.Data;
using SupportForum.Data.Models;
using SupportForum.Models.Forum;
using SupportForum.Models.Post;
using SupportForum.Models.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportForum.Controllers
{
    public class SearchController : Controller
    {
        private readonly IPost _postService;

        public SearchController(IPost postService)
        {
            _postService = postService;
        }

        public IActionResult Results(string searchQuery)
        {
            var posts = _postService.GetFilteredPosts(searchQuery);
            var areNoResults = (!string.IsNullOrEmpty(searchQuery) && !posts.Any());
            var postListings = posts.Select(post => new PostListViewModel
            {
                Id = post.Id,
                AuthorId = post.User.Id,
                AuthorName = post.User.UserName,
                AuthorRating = post.User.Rating,
                DatePosted = post.Created.ToString(),
                RepliesCount = post.Replies.Count(),
                Title = post.Title,
                Forum = BuildForumList(post)
            });
            var model = new SearchResultViewModel
            {
                Posts = postListings,
                SearchQuery = searchQuery,
                EmptySearchResults = areNoResults
            };
            return View(model);
        }

        private ForumListViewModel BuildForumList(Post post)
        {
            var forum = post.Forum;
            return new ForumListViewModel
            {
                Id = forum.Id,
                Description = forum.Description,
                ImageUrl = forum.ImageUrl,
                Name = forum.Title
            };
        }

        [HttpPost]
        public IActionResult Search(string searchQuery)
        {
            return RedirectToAction("Results", new { searchQuery });
        }
    }
}
