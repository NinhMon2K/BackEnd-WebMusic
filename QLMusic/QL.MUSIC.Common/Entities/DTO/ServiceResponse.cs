using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL.MUSIC.Common.Entities
{
    /// <summary>
    /// Dữ liệu trả về tầng BL
    /// </summary>
    public class ServiceResponse
    {
        /// <summary>
        /// Thành công hay Thất bại
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Dữ liệu đi kèm khi thành công hoặc thất bại
        /// </summary>
        public object Data { get; set; }
    }
}
