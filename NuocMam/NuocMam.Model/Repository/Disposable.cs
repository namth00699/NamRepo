using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuocMam.Model.Repository
{
    public class Disposable : IDisposable
    {
        private bool IsDisposed;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        ~Disposable()
        {
            Dispose(false);
        }

        private void Dispose(bool v)
        {
            if(!IsDisposed&&v)
            {
                DisposeCore();
            }
            IsDisposed = true;
        }
        protected virtual void DisposeCore() { }
    }
}
