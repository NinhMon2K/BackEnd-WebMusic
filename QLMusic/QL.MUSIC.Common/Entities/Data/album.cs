
using QL.MUSIC.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace QL.MUSIC.Common.Entities
{
    public class album
    {
        [PrimaryKey]
        [IsNotNullOrEmpty("ID  không được để trống")]
        public int id { get; set; }

        
        [IsNotNullOrEmpty("ID  không được để trống")]
        public string name { get; set; }
        [IsNotNullOrEmpty("ID  không được để trống")]
        public string image { get; set; }
    }
}
