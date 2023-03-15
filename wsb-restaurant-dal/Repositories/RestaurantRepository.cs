using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wsb_restaurant_dal.Contracts;
using wsb_restaurant_models.EFMigration.Models.Entities;

namespace wsb_restaurant_dal.Repositories
{
    internal class RestaurantRepository : IRestaurantRepository
    {
        public void Delete(int restaurantId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Restaurant> GetAll()
        {
            throw new NotImplementedException();
        }

        public Restaurant GetById(int restaurantId)
        {
            throw new NotImplementedException();
        }

        public void Insert(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }
    }
}
