using NuocMam.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuocMam.Model.Repository
{
    public class AspNetUserRepo :BaseRepository,IAspNetUser
    {
        public AspNetUserRepo(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }

        public IList<AspNetUser> GetAllUser()
        {
            return DatabaseEntities.AspNetUsers.ToList();
        }
    }
}
