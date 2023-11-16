using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using wsb_restaurant_dal.Context;
using wsb_restaurant_dal.Contracts;
using wsb_restaurant_domain.Models.Entities;

namespace wsb_restaurant_dal.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public UserRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task DeleteAsync(Guid User)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<User> FindAsync(Expression<Func<User, bool>> predicate)
        {
            var foundUser = await applicationDbContext.Users.FirstOrDefaultAsync(predicate);

            return foundUser;
        }

        public async Task InsertAsync(User user)
        {
            await applicationDbContext.AddAsync(user);
            applicationDbContext.SaveChanges();
        }

        public async Task SaveAsync()
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(User User)
        {
            throw new NotImplementedException();
        }
    }
}
