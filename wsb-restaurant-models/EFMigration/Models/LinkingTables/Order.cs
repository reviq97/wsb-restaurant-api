using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsb_restaurant_models.EFMigration.Models.LinkingTables
{
    public class Order
    {
        public int Id { get; set; }
        public int FoodOrderId { get; set; }
        public int DishId { get; set; }
        public string OrderType { get; set; }
        public DateTime OrderRequestDate { get; set; }
        public int Quantity { get; set; }
    }
}
