using QL.MUSIC.Common.Entities;
using QL.MUSIC.Common.Entities.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL.MUSIC.BL
{
    public interface IAccountBL : IBaseBL<account>
    { 
             public PagingData<account> FilterAccounts(PagingSong pagingAsset);
    }
}
