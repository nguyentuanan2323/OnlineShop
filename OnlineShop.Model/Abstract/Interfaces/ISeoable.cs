using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Model.Abstract.ClassAbstract
{
    public class ISeoable
    {
        [MaxLength]
        public string MetaKeyWord { set; get; }
        [MaxLength]
        public string MetaDesciption { set; get; }

    }
}
