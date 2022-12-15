using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL.MUSIC.Common.Entities
{
    public class ServiceResult
    {
        public ServiceResultType status_code { get; set; } = ServiceResultType.Success;

        public object Data { get; set; }

        public string Message { get; set; }

    }
}
