using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Model.Abstract
{
    public interface IAudittable
    {
        DateTime CreateDate { set; get; }
        string CreateBy { set; get; }
        DateTime? UpdateDate { set; get; }
        string UpdateBy { set; get; }
        [MaxLength]
        string MetaKeyWord { set; get; }
        [MaxLength]
        string MetaDesciption { set; get; }
        bool Status { get; set; }
    }
}
