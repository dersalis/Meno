using Meno.Core.Entities;
using Meno.Infrastructure.Abstractions;

namespace Meno.Infrastructure.DAL.Repositories.InMemory
{
    public class InMemoryUserRepository : IRepository<User>
    {
        public Task AddAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(User entity)
        {
            throw new NotImplementedException();
        }
    }
}