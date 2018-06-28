using OnlineShop.Model.Abstract.ClassAbstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Model.Models
{
    [Table("Menus")]
    public class Menu : BaseEntity
    {
        public string Name { get; set; }
        public string URL { get; set; }
        public int DisplayOrder { get; set; }

        public int GroupId { get; set; }
        public MenuGroup Group { get; set; }

        public string Target { get; set; }
        public bool Status { get; set; }

    }
}
