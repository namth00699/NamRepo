using NuocMam.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuocMam.Model.Repository
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private NuocMamRealEntities _databaseEntities;
        public NuocMamRealEntities Get()
        {
            if(_databaseEntities == null)
            {
                _databaseEntities = new NuocMamRealEntities();
            }
            return _databaseEntities;
        }
        protected override void DisposeCore()
        {
            if(_databaseEntities != null)
            {
                _databaseEntities.Dispose();
            }
        }
    }
}
