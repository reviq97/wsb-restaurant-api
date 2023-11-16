using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wsb_restaurant_domain.Models.Entities;

namespace wsb_restaurant_dal.Contracts
{
    public interface IAddressRepository
    {
        IEnumerable<Address> GetAll();
        Address GetById(int addressId);
        void Insert(Address address);
        void Update(Address address);
        void Delete(int addressId);
        void Save();
    }
}
