using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportForum.Models.Forum
{
    public class ForumIndexViewModel
    {
        public IEnumerable<ForumListViewModel> ForumList { get; set; }
    }
}
