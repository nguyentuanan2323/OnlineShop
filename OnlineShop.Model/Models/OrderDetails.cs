using OnlineShop.Model.Abstract.ClassAbstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Model.Models
{
    public class OrderDetail : BaseEntity
    {
        public string Quantity { get; set; }
        public int ProductId { set; get; }

        

        public int OrderId { set; get; }
        public Order Order { set; get; }

        [ForeignKey("ProductId")]
        public Product Product { set; get; }
    }
}
