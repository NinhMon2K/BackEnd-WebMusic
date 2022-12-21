using QL.MUSIC.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace QL.MUSIC.Common.Entities
{
    public class singerfavor
    {
        [IsNotNullOrEmpty("accountId  không được để trống")]
        public int accountId { get; set; }
        [IsNotNullOrEmpty("singerId  không được để trống")]
        public int singerId { get; set; }
    }
}
