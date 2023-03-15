using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wsb_restaurant_dal.Contracts;
using wsb_restaurant_models.EFMigration.Models.LinkingTables;
using wsb_restaurant_models.Repository;

namespace wsb_restaurant_dal.Repositories
{
    internal class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public OrderRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public void Delete(int orderId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Order GetById(int orderId)
        {
            throw new NotImplementedException();
        }

        public void Insert(Order order)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
