using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL.MUSIC.Common.Entities
{
    public class PagingSong
    {
        /// <summary>
        /// Giá trị tìm kiếm theo mã tài sản hoặc loại tài sản
        /// </summary>
        public string? keyword { get; set; }
        public int? limit { get; set; }

        /// <summary>
        /// Trang đứng hiện tại
        /// </summary>
        public int? page { get; set; }
        public PagingSong() { }

        public PagingSong(string? keyword, int? limit, int? page)
        {
            this.keyword = keyword;
            this.limit = limit;
            this.page = page;
        }
    }
}
