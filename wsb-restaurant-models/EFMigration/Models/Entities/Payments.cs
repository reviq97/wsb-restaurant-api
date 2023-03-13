using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsb_restaurant_models.EFMigration.Models.Entities
{
    public class Payments
    {
        public int Id { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentAmount { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
