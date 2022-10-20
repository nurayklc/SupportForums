using Microsoft.AspNetCore.Mvc;
using SupportForum.Data;
using SupportForum.Data.Models;
using SupportForum.Models.Forum;
using SupportForum.Models.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportForum.Controllers
{
    public class ForumController : Controller
    {
        private readonly IForum _forumService;
        private readonly IPost _postService;
        public ForumController(IForum forumService, IPost postService)
        {
            _forumService = forumService;
            _postService = postService;
        }
        public IActionResult Index()
        {
            var forums = _forumService.GetAll()
                .Select(forum => new ForumListViewModel { 
                Id = forum.Id,
                Name = forum.Title,
                Description = forum.Description
            });

            var model = new ForumIndexViewModel
            {
                ForumList = forums
            };

            return View(model);
        }

        public IActionResult Topic(int id, string searchQuery)
        {
            var forum = _forumService.GetById(id);
            var posts = _postService.GetFilteredPosts(forum, searchQuery).ToList();

            var postLists = posts.Select(post => new PostListViewModel
            {
                Id = post.Id,
                AuthorId = post.User.Id,
                AuthorRating = post.User.Rating,
                AuthorName = post.User.UserName,
                Title = post.Title,
                DatePosted = post.Created.ToString(),
                RepliesCount = post.Replies.Count(),
                Forum = BuildForumList(post)
            });

            var model = new ForumTopicViewModel
            {
                Forum = BuildForumList(forum),
                Posts = postLists
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Search(int id, string searchQuery)
        {
            return RedirectToAction("Topic", new { id, searchQuery} );
        }

        private ForumListViewModel BuildForumList(Post post)
        {
            var forum = post.Forum;
            return BuildForumList(forum);
        }
        private ForumListViewModel BuildForumList(Forum forum)
        {
            return new ForumListViewModel
            {
                Id = forum.Id,
                Name = forum.Title,
                Description = forum.Description,
                ImageUrl = forum.ImageUrl,
            };
        }
    }
}
