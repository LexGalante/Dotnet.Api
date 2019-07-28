using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net.Core.Api.Helpers
{
    public class JwtSettings
    {
        public string Secret { get; set; }
        public string Issuer { get; set; }
        public string[] Audiences { get; set; }
        public int ExpiresAt { get; set; }
    }
}
