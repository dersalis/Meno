using Meno.Core.Entities;
using Meno.Infrastructure.Abstractions;

namespace Meno.Infrastructure.DAL.Repositories.InMemory
{
    public class InMemoryCategoryRepository : IRepository<Category>
    {
        public Task AddAsync(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Category>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}