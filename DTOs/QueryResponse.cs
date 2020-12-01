using System;
using System.Collections.Generic;
using System.Linq;

namespace Jwpro.Api.Proxy.DTOs
{
    public class ApiQueryResponse<T>
    {
        public bool Done { get; set; }
        public List<T> Records { get; set; }
        public int TotalSize { get; set; }
    }
}
