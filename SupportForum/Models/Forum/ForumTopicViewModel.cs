using SupportForum.Models.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportForum.Models.Forum
{
    public class ForumTopicViewModel
    {
        public ForumListViewModel Forum { get; set; }
        public IEnumerable<PostListViewModel> Posts { get; set; }
    }
}
