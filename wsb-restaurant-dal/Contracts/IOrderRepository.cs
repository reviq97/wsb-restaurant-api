﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wsb_restaurant_models.EFMigration.Models.Entities;
using wsb_restaurant_models.EFMigration.Models.LinkingTables;

namespace wsb_restaurant_dal.Contracts
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAll();
        Order GetById(int orderId);
        void Insert(Order order);
        void Update(Order order);
        void Delete(int orderId);
        void Save();
    }
}
