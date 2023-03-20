using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsb_restaurant_application.Services.Authentication
{
    public record AuthenticationResult(Guid id, string firstName, string lastName, string email, string token);
}
