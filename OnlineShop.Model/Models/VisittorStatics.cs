using OnlineShop.Model.Abstract.ClassAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Model.Models
{
    public class VisittorStatics
    {
        public Guid Id { set; get; }
        public DateTime VisitedDate { set; get; }
        public string IPAddress { set; get; }
    }
}
