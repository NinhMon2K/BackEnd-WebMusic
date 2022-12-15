using System;
using System.Collections.Generic;
using System.Text;

namespace QL.MUSIC.Common.Entities
{
    public class banner
    {
        public int id { get; set; }
        public string image { get; set; }
        public string text { get; set; }

        public int songId { get; set; }
    }
}
