using OnlineShop.Model.Abstract;
using OnlineShop.Model.Abstract.ClassAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OnlineShop.Model.Models
{
    public class Product : BaseEntity, IAudittable
    {

        public DateTime CreateDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CreateBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? UpdateDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UpdateBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MetaKeyWord { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MetaDesciption { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Alias { get; set; }

        public int ProductCategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }

        
        public string Image { get; set; }
        public XElement MoreImages { set; get; }
        public decimal Price { set; get; }
        public decimal? PromotionPrice { set; get; }
        public int? Warranty { set; get; }
        public string Desciption { set; get; }
        public string Content { set; get; }

        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }

    }
}
