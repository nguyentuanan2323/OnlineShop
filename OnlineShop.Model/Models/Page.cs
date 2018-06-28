using OnlineShop.Model.Abstract.ClassAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Model.Models
{
    public class Page : BaseEntity
    {
        public string Name { get; set; }
        public string Alias { set; get; }
        public string Content { get; set; }
    }
}
