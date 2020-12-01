using System;
using System.Collections.Generic;
using System.Linq;

namespace Jwpro.Api.Proxy.Configuration
{
    public class SalesForceConfiguration
    {
        public string AccountToken { get; set; }

        public string ApiUrl { get; set; }

        public string AuthorizationUrl { get; set; }

        public string Key { get; set; }

        public string Password { get; set; }

        public string Secret { get; set; }

        public string Username { get; set; }
    }
}
