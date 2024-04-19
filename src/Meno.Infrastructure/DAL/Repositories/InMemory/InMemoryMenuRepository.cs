using Meno.Core.Entities;
using Meno.Infrastructure.Abstractions;

namespace Meno.Infrastructure.DAL.Repositories.InMemory
{
    public class InMemoryMenuRepository : IRepository<Menu>
    {
        public Task AddAsync(Menu entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Menu>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Menu> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Menu entity)
        {
            throw new NotImplementedException();
        }
    }
}