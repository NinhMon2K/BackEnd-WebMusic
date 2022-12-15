using QL.MUSIC.Common.Attributes;
using QL.MUSIC.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QL.MUSIC.Common.Entities.Data
{
    public class account : UserInfo
    {
        [PrimaryKey]
        [IsNotNullOrEmpty("ID  không được để trống")]
        public int id { get; set; }
        [IsNotNullOrEmpty("Tên tài khoản không được để trống")]
        public string accountName { get; set; }
        [IsNotNullOrEmpty("Mật khẩu không được để trống")]
        public string password { get; set; }

    }
}
