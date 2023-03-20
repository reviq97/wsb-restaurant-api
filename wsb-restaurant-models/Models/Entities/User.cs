using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsb_restaurant_models.Models.Entities
{
    public record User(Guid id, string firstName, string lastName, string email, string password);
}
