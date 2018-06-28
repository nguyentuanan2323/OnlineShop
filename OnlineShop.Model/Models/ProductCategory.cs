using OnlineShop.Model.Abstract;
using OnlineShop.Model.Abstract.ClassAbstract;
using System;
using System.Collections.Generic;

namespace OnlineShop.Model.Models
{
    public class ProductCategory : BaseEntity, IAudittable
    {
        public Product Product { get; set; }
        public string Alias { set; get; }
        public string Desciption { set; get; }

        public ICollection<Product> Products { get; set; }

        public int? ParrentId { set; get; }
        public string DisplayOrder { set; get; }
        public string Image { set; get; }

        public bool? HomeFlag { set; get; }
        public DateTime CreateDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CreateBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? UpdateDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UpdateBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MetaKeyWord { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MetaDesciption { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}