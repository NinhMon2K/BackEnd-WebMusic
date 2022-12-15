using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL.MUSIC.Common.Entities
{
    /// <summary>
    /// Dữ liệu cho phân trang
    /// </summary>
    public class PagingData<T>
    {
        #region Propety

        /// <summary>
        /// Danh sách các bản ghi hiển thị
        /// </summary>
        public IEnumerable<T> Data { get; set; }

        /// <summary>
        /// Tổng số bản ghi hiển thị
        /// </summary>
        public long TotalCount { get; set; }

        #endregion

        #region Constructor

        public PagingData() { }

        public PagingData(IEnumerable<T> data, long totalCount)
        {
            Data = data;
            TotalCount = totalCount;
        }

        #endregion
    }
}
