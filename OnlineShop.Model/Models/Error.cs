using OnlineShop.Model.Abstract.ClassAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Model.Models
{
    public class Error : BaseEntity
    {
        public string Message { set; get; }
        public string StackTrace { get; set; }
        public DateTime Createdate { set; get; }
    }
}
