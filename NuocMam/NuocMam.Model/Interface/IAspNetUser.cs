using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuocMam.Model.Interface
{
    public interface IAspNetUser
    {
        IList<AspNetUser> GetAllUser();
    }
}
