using OnlineShop.Model.Abstract.ClassAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Model.Models
{
    public class SupportOnline : BaseEntity
    {
        public string Name { set; get; }
        public string Department { set; get; }

        public string Skype { set; get; }
        public string Mobile { set; get; }

        public string Yahoo { set; get; }
        public string Facebook { set; get; }
        public bool Status { set; get; }
        public int? DisplayOrder { set; get; }
    }
}
