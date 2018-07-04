using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Infrastructor
{
    public class Disposable : IDisposable
    {
        ~Disposable()
        {
            Dispose(false);
        }
        
        private bool isDisposaed;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if(!isDisposaed && disposing)
            {
                DisposeCore();
            }
            isDisposaed = true;
        }
        protected virtual void DisposeCore()
        {

        }
    }
}
