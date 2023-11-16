using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsb_restaurant_domain.Models.Entities
{
    public class CustomerContact
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ContactId { get; set; }
    }
}
