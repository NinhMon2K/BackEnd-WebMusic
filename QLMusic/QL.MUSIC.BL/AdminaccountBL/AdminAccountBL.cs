using QL.MUSIC.Common.Entities;
using QL.MUSIC.Common.Entities.Data;
using QL.MUSIC.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL.MUSIC.BL
{
    public class AdminAccountBL : BaseBL<adminaccount>, IAdminAccountBL
    {
        #region Field

        private IAdminAccountDL _adminaccountDL;

        #endregion
        public AdminAccountBL(IAdminAccountDL adminAccountDL) : base(adminAccountDL)
        {
            _adminaccountDL = adminAccountDL;
        }

        public PagingData<adminaccount> FilterAdminAccounts(PagingSong pagingAsset)
        {
            return _adminaccountDL.FilterAdminAccounts(pagingAsset);
        }

    }
}
