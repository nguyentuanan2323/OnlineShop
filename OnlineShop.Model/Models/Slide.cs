using OnlineShop.Model.Abstract.ClassAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Model.Models
{
    public class Slide : BaseEntity
    {
        public string Name { set; get; }
        public string Desciption { set; get; }
        public string Url { set; get; }
        public int? DisplayOrder { set; get; }
        public bool Status { set; get; }
    }
}
