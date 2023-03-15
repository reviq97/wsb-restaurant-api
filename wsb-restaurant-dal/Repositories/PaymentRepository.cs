using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wsb_restaurant_dal.Contracts;
using wsb_restaurant_models.EFMigration.Models.Entities;
using wsb_restaurant_models.Repository;

namespace wsb_restaurant_dal.Repositories
{
    internal class PaymentRepository : IPaymentRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public PaymentRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public void Delete(int paymentId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Payment> GetAll()
        {
            throw new NotImplementedException();
        }

        public Payment GetById(int paymentId)
        {
            throw new NotImplementedException();
        }

        public void Insert(Payment payment)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Payment payment)
        {
            throw new NotImplementedException();
        }
    }
}
