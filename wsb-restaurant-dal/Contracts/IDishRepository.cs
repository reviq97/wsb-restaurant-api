using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wsb_restaurant_models.EFMigration.Models.Entities;

namespace wsb_restaurant_dal.Contracts
{
    public interface IDishRepository
    {
        IEnumerable<Dish> GetAll();
        Dish GetById(int dishId);
        void Insert(Dish dish);
        void Update(Dish dish);
        void Delete(int dishId);
        void Save();
    }
}
