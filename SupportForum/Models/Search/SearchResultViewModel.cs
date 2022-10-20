using SupportForum.Models.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportForum.Models.Search
{
    public class SearchResultViewModel
    {
        public IEnumerable<PostListViewModel> Posts { get; set; }
        public string SearchQuery { get; set; }
        public bool EmptySearchResults { get; set; }
    }
}
