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
        public ForumController(IForum forumService)
        {
            _forumService = forumService;
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

        public IActionResult Topic(int id)
        {
            var forum = _forumService.GetById(id);
            var posts = forum.Posts;
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
