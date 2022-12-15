using QL.MUSIC.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL.MUSIC.BL
{
    public interface ISongBL : IBaseBL<song>
    {
        public PagingData<song> FilterSongs(PagingSong pagingAsset);
    }
}
