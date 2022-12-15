using QL.MUSIC.Common.Entities;
using QL.MUSIC.Common.Entities.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL.MUSIC.BL
{
    public interface IAdminAccountBL : IBaseBL<adminaccount>
    {
        public PagingData<adminaccount> FilterAdminAccounts(PagingSong pagingAsset);
    }
}
