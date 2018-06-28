using OnlineShop.Model.Abstract.ClassAbstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Model.Models
{
    public class Post : Audittable
    {
        public string Name { set; get; }
        public string Alias { set; get; }
        public string CetegoryId { set; get; }
        public string Image { set; get; }
        public string Descipttion { set; get; }
        public string Content { set; get; }
        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? viewCount { set; get; }
        
        public int PostCategoryId { get; set; }
        public virtual PostCategory PostCategory { set; get; }
    }
}
