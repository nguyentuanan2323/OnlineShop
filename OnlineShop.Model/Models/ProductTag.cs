using OnlineShop.Model.Abstract.ClassAbstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Model.Models
{
    public class ProductTag : BaseEntity
    {
        public int PostId { set; get; }
        public Post Post { set; get; }

        public int TagId {set;get;}
        public Tag Tag { get; set; }


    }
}
