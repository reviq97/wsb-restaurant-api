using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wsb_restaurant_models.EFMigration.Models.Entities;

namespace wsb_restaurant_dal.Contracts
{
    public interface IPaymentRepository
    {
        IEnumerable<Payment> GetAll();
        Payment GetById(int paymentId);
        void Insert(Payment payment);
        void Update(Payment payment);
        void Delete(int paymentId);
        void Save();
    }
}
