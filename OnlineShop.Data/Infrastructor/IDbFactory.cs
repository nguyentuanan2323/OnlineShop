using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Infrastructor
{
    public  interface IDbFactory : IDisposable
    {
        OnlineShopDbContext Init();
      
    }
}
