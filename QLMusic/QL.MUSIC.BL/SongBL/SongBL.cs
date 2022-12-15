using QL.MUSIC.Common.Entities;
using QL.MUSIC.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL.MUSIC.BL
{
    public class SongBL : BaseBL<song>, ISongBL
    {
        #region Field

        private ISongDL _songDL;

        #endregion

        #region Constructer

        public SongBL(ISongDL songDL) : base(songDL)
        {
            _songDL = songDL;
        }

        #endregion
        public PagingData<song> FilterSongs(PagingSong pagingAsset)
        {
            return _songDL.FilterSongs(pagingAsset);
        }
    }
}
