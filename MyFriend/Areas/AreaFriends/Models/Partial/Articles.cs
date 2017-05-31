using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyFriend.Areas.AreaFriends.Models
{
    [MetadataType(typeof(ArticlesMetadata))]
    public partial class Articles
    {
        public class ArticlesMetadata
        {
            [DisplayName("文章編號")]
            public int ArticleID { get; set; }
            [DisplayName("文章標題")]
            public string ArticleTitle { get; set; }
            [DisplayName("文章內容")]
            public string ArticleContent { get; set; }
            [DisplayName("發文日期")]
            public System.DateTime? ArticleDate { get; set; }
            [DisplayName("活動編號")]
            public int ActivityID { get; set; }
            [DisplayName("希望人數")]
            public int WishNumber { get; set; }
            [DataType(DataType.Date)]
            [DisplayName("希望日期")]
            [DisplayFormat(DataFormatString = "{0:d}")]
            public System.DateTime? WishDate { get; set; }
            [DisplayName("活動地點")]
            public string Address { get; set; }
        }
    }
}