using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jwpro.Api.Proxy.DTOs
{
    public class Address
    {
        public string City { get; set; }
        public object Country { get; set; }
        public object GeocodeAccuracy { get; set; }
        public object Latitude { get; set; }
        public object Longitude { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
    }
}
