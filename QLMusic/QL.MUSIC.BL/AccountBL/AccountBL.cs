using QL.MUSIC.Common.Entities;
using QL.MUSIC.Common.Entities.Data;
using QL.MUSIC.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace QL.MUSIC.BL
{
    public class AccountBL : BaseBL<account>, IAccountBL
    {
        #region Field

        private IAccountDL _accountDL;

        #endregion

        #region Constructer

        public AccountBL(IAccountDL accountDL) : base(accountDL)
        {
            _accountDL = accountDL;
        }

        public PagingData<account> FilterAccounts(PagingSong pagingAsset)
        {
            return _accountDL.FilterAccounts(pagingAsset);
        }

        #endregion
      
    }
}
