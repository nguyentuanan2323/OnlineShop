using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Model.Abstract.ClassAbstract
{
    public class BaseEntity
    {
        [Key]
        public int Id { set; get; }

       
    }
}
