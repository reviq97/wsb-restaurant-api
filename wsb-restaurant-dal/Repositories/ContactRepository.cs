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
    public class ContactRepository : IContactRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ContactRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public void Delete(int contactId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contact> GetAll()
        {
            throw new NotImplementedException();
        }

        public Contact GetById(int contactId)
        {
            throw new NotImplementedException();
        }

        public void Insert(Contact contact)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
