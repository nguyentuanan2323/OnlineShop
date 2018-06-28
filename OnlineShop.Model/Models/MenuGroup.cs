using OnlineShop.Model.Abstract.ClassAbstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Model.Models
{
    [Table("MenuGroups")]
    public class MenuGroup : BaseEntity
    {
        public ICollection<Menu> Menus { get; set; }
    }
}