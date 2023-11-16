using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsb_restaurant_domain.Models.Entities
{
    public class RestaurantAddress
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public int AddressId { get; set; }

    }
}
