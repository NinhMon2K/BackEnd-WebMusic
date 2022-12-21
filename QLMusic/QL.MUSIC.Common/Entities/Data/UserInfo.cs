using QL.MUSIC.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace QL.MUSIC.Common.Entities
{
    public class UserInfo
    {
     
        [IsNotNullOrEmpty("ID  không được để trống")]
        public int accountId { get; set; }
        [IsNotNullOrEmpty("ID  không được để trống")]
        public string name { get; set; }
        [IsNotNullOrEmpty("ID  không được để trống")]
        public string avatar { get; set; }
        [IsNotNullOrEmpty("ID  không được để trống")]
        public string phone { get; set; }
        [IsNotNullOrEmpty("ID  không được để trống")]
        public int sex { get; set; }
        [IsNotNullOrEmpty("ID  không được để trống")]
        public string birthday { get; set; }

    }
}
