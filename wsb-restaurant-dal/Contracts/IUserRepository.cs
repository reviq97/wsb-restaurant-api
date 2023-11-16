using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using wsb_restaurant_domain.Models.Entities;

namespace wsb_restaurant_dal.Contracts
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAll();
        Task<User> FindAsync(Expression<Func<User,bool>> predicate);
        Task InsertAsync(User user);
        Task UpdateAsync(User User);
        Task DeleteAsync(Guid User);
        Task SaveAsync();
    }
}
