using OnlineShop.Model.Abstract.ClassAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Model.Models
{
    public class PostTag : BaseEntity
    {
       public string TagId { set; get; }
        public Post PostId { set; get; }
        public virtual Post Post { get; set; }
        public virtual Tag Tag { set; get; }
    }
}
