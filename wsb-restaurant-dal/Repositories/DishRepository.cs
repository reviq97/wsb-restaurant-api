﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wsb_restaurant_dal.Contracts;
using wsb_restaurant_models.EFMigration.Models.Entities;

namespace wsb_restaurant_dal.Repositories
{
    internal class DishRepository : IDishRepository
    {
        public void Delete(int dishId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Dish> GetAll()
        {
            throw new NotImplementedException();
        }

        public Dish GetById(int dishId)
        {
            throw new NotImplementedException();
        }

        public void Insert(Dish dish)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Dish dish)
        {
            throw new NotImplementedException();
        }
    }
}