using QL.MUSIC.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace QL.MUSIC.Common.Entities
{ 
    public class albumFavor
    {
        [IsNotNullOrEmpty("accountId  không được để trống")]
        public int accountId { get; set; }
        [IsNotNullOrEmpty("albumId  không được để trống")]
        public int albumId { get; set; }
    }
}
