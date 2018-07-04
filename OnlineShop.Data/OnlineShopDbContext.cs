using OnlineShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Infrastructor
{
    public class OnlineShopDbContext : DbContext
    {
        public OnlineShopDbContext() : base("OnlineShopConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Footer> Footers { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<MenuGroup> FooteMenuGrouprs { set; get; }

        public DbSet<Order> Order { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        public DbSet<Page> Pages { set; get; }
        public DbSet<Post> Posts { set; get; }

        public DbSet<PostCategory> PostCategorys { set; get; }
        public DbSet<PostTag> PostTags { set; get; }
        public DbSet<Slide> Slides { set; get; }
        public DbSet<Tag> Tag { set; get; }
        public DbSet<VisittorStatics> FooteVisittorStatics { set; get; }
        public DbSet<PostCategory> PostCategory { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }

}
