using System;

namespace OnlineShop.Model.Abstract.ClassAbstract
{
    public abstract class Audittable : IAudittable
    {
        public DateTime CreateDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CreateBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? UpdateDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UpdateBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MetaKeyWord { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MetaDesciption { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}