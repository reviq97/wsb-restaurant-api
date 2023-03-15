using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wsb_restaurant_models.EFMigration.Models.Entities;

namespace wsb_restaurant_dal.Contracts
{
    public interface IContactRepository
    {
        IEnumerable<Contact> GetAll();
        Contact GetById(int contactId);
        void Insert(Contact contact);
        void Update(Contact contact);
        void Delete(int contactId);
        void Save();
    }
}
