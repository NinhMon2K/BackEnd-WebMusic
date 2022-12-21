using QL.MUSIC.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL.MUSIC.Common.Entities
{
    public class adminaccount
    {
       
        [IsNotNullOrEmpty("ID  không được để trống")]
        public int id { get; set; }
        [PrimaryKey]
        [IsNotNullOrEmpty("Tài khoản không được để trống")]
        public string accountName { get; set; }
        [IsNotNullOrEmpty("Mật khẩu không được để trống")]
        public string password { get; set; }
    }
}
