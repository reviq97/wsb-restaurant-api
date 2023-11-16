using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsb_restaurant_infrastructure.Authentication
{
    public class JwtAppSettings
    {
        public string Issuer { get; set; }
        public string Secret { get; set; }
        public int ExpirationMin { get; set; }
        public string Audience { get; set; }
    }
}
