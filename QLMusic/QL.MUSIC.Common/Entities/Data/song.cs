using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace QL.MUSIC.Common.Entities
{
    public class song
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string link { get; set; }
        public string keyYTB { get; set; }

    }
}
