﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsb_restaurant_domain.Models.Entities
{
    public class OrderPayment
    {
        public int Id { get; set; }
        public int FoodOrder { get; set; }
        public int PaymentId { get; set; }
    }
}
