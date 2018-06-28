using OnlineShop.Model.Abstract.ClassAbstract;
using System.Collections.Generic;

namespace OnlineShop.Model.Models
{
    public class PostCategory : BaseEntity
    {
        public string Name { get; set; }
        public string Alias { get; set; }

        public string Desciption { set; get; }
        public int? ParrentId { set; get; }
        public int? DisplayOrder { set; get; }

        public string Image { set; get; }
        public bool? HomeFlag { set; get; }
        public ICollection<Post> Post { set; get; }
    }
}