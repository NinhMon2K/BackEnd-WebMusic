using QL.MUSIC.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace QL.MUSIC.Common.Entities
{
    public class songFavor
    {
        [IsNotNullOrEmpty("accountId  không được để trống")]
        public int accountId { get; set; }
        [IsNotNullOrEmpty("songId  không được để trống")]
        public int songId { get; set; }
    

    }
}
