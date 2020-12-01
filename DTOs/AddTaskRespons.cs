using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jwpro.Api.Proxy.DTOs
{
    public class AddTaskResponse
    {
        public List<object> errors { get; set; }

        public string id { get; set; }

        public bool success { get; set; }
    }
}
