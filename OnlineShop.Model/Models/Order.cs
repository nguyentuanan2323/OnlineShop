using OnlineShop.Model.Abstract.ClassAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Model.Models
{
    public class Order : BaseEntity   {
        public int MyProperty { get; set; }
        public string CustomerName { set; get; }
        public string CustomerAddress { set; get; }
        public string CustomerEmail { set; get; }
        public string CustomerMobile { set; get; }

        public string CustomerMessage { set; get; }
        public string PaymentMedthoad { set; get; }
        public DateTime? CreateDate { set; get; } 
        public string CreateBy { set; get; }
        public string PaymentStatus { set; get; }
        public string Status { get; set; }

        public ICollection<OrderDetail> OrderDetails { set; get; }


    }
}
