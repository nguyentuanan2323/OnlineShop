using OnlineShop.Model.Abstract.ClassAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Model.Models
{
    public class SystemConfig : BaseEntity
    {
        public string Code { set; get; }
        public string ValueString { set; get; }

        public int? ValueInt { set; get; }

    }
}
