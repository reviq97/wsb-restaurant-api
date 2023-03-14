using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace wsb_restaurant_models.EFMigration.Models.Entities
{
    public class Dish
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        public string DishImageUrl { get; set; }

        public decimal Price { get; set; }
    }
}
