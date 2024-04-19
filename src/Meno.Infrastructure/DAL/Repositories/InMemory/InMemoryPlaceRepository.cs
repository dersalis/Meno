using Meno.Core.Entities;
using Meno.Infrastructure.Abstractions;

namespace Meno.Infrastructure.DAL.Repositories.InMemory
{
    public class InMemoryPlaceRepository : IRepository<Place>
    {
        public Task AddAsync(Place entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Place>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Place> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Place entity)
        {
            throw new NotImplementedException();
        }
    }
}