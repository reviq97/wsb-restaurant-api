using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsb_restaurant_domain.Models.Entities
{
    public class OrderStatus
    {
        public int Id { get; set; }
        public int OrderDetailId { get; set; }
        public string Status { get; set; }
    }
}
