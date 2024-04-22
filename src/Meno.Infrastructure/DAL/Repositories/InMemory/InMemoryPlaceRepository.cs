using Meno.Core.Entities;
using Meno.Core.ValueObjects;
using Meno.Infrastructure.Abstractions;

namespace Meno.Infrastructure.DAL.Repositories.InMemory
{
    public class InMemoryPlaceRepository : IRepository<Place>
    {
        private readonly List<Place> _places;

        public InMemoryPlaceRepository()
        {
            _places = FakeDataGenerator.GeneratePlaces();
        }

        public Task AddAsync(Place entity)
        {
            _places.Add(entity);
            return Task.CompletedTask;
        }

        public Task DeleteAsync(Guid id)
        {
            _places.RemoveAll(p => p.Id == (ID)id);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<Place>> GetAllAsync()
        {
            return Task.FromResult(_places.AsEnumerable());
        }

        public Task<Place> GetAsync(Guid id)
        {
            return Task.FromResult(_places.FirstOrDefault(p => p.Id == (ID)id));
        }

        public Task UpdateAsync(Place entity)
        {
            return Task.CompletedTask;
        }
    }
}