using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;

namespace bbs.Models
{
    public class PostModelView
    {
        public List<Post> Posts { get;set; }
        public string SortOrder { get; set; }
        public IEnumerable<SelectListItem> SortOptions { get; set; }
        public string SearchString { get; set; }
        public string CurrentUser { get; set; }

        public PostModelView()
        {
            SortOptions = new List<SelectListItem>
            {
                new SelectListItem { Value = "content_asc", Text = "内容（昇順）" },
                new SelectListItem { Value = "content_desc", Text = "内容（降順）" },
                new SelectListItem { Value = "userName_asc", Text = "ユーザー（昇順）" },
                new SelectListItem { Value = "userName_desc", Text = "ユーザー（降順）" },
                new SelectListItem { Value = "createdAt_asc", Text = "投稿時間（昇順）" },
                new SelectListItem { Value = "createdAt_desc", Text = "投稿時間（降順）" }
            };
        }
    }
}
