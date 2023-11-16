using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wsb_restaurant_dal.Context;
using wsb_restaurant_dal.Contracts;
using wsb_restaurant_domain.Models.Entities;

namespace wsb_restaurant_dal.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public AddressRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public void Delete(int addressId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Address> GetAll()
        {
            throw new NotImplementedException();
        }

        public Address GetById(int addressId)
        {
            throw new NotImplementedException();
        }

        public void Insert(Address address)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Address address)
        {
            throw new NotImplementedException();
        }
    }
}
