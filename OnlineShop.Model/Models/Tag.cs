using OnlineShop.Model.Abstract.ClassAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Model.Models
{
    public class Tag : BaseEntity
    {
        public string Name { set; get; }
        public string Type { set; get; }

        public ICollection<ProductTag> ProductTag { set; get; }
    }
}
