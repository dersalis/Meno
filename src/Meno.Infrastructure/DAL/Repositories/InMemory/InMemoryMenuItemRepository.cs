using Meno.Core.Entities;
using Meno.Infrastructure.Abstractions;

namespace Meno.Infrastructure.DAL.Repositories.InMemory
{
    public class InMemoryMenuItemRepository : IRepository<MenuItem>
    {
        public Task AddAsync(MenuItem entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MenuItem>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<MenuItem> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(MenuItem entity)
        {
            throw new NotImplementedException();
        }
    }
}