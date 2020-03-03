using NuocMam.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuocMam.Model.Repository
{
    public abstract class BaseRepository
    {
        private NuocMamRealEntities _entities;
        protected IDatabaseFactory DatabaseFactory { get;private set; }
        public BaseRepository(IDatabaseFactory databaseFactory)
        {
            DatabaseFactory = databaseFactory;
        }
        protected NuocMamRealEntities DatabaseEntities {
            get
            {
                return _entities ??(_entities = DatabaseFactory.Get());
            }
        }
    }
}
