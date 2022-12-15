using QL.MUSIC.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL.MUSIC.DL
{
    public interface IAdminAccountDL : IBaseDL<adminaccount>
    {
        public PagingData<adminaccount> FilterAdminAccounts(PagingSong pagingSong);
    }
}
