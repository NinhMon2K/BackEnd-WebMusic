using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace QL.MUSIC.Common.Entities
{
    public class UserInfo
    {
        public int accountId { get; set; }
        public string name { get; set; }
        public string avatar { get; set; }
        public string phone { get; set; }
        public int sex { get; set; }
        public string birthday { get; set; }

    }
}
