using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wsb_restaurant_models.EFMigration.Models.Entities;

namespace wsb_restaurant_dal.Contracts
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAll();
        Customer GetById(int customerId);
        void Insert(Customer customer);
        void Update(Customer customer);
        void Delete(int customerId);
        void Save();
    }
}
