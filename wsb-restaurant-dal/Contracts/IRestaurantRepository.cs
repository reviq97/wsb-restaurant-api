using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wsb_restaurant_domain.Models.Entities;

namespace wsb_restaurant_dal.Contracts
{
    public interface IRestaurantRepository
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant GetById(int restaurantId);
        void Insert(Restaurant restaurant);
        void Update(Restaurant restaurant);
        void Delete(int restaurantId);
        void Save();
    }
}
