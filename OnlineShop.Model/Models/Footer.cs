using OnlineShop.Model.Abstract.ClassAbstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Model.Models
{
    [Table("Footers")]
    public class Footer : BaseEntity
    {
        public string Name { set; get; }
        [Required]
        public string Content { set; get; }
    }
}