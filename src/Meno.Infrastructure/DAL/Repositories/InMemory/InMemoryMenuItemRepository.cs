using Meno.Core.Entities;
using Meno.Core.ValueObjects;
using Meno.Infrastructure.Abstractions;

namespace Meno.Infrastructure.DAL.Repositories.InMemory
{
    public class InMemoryMenuItemRepository : IRepository<MenuItem>
    {
        public readonly List<MenuItem> _menuItems;

        public InMemoryMenuItemRepository()
        {
            _menuItems = FakeDataGenerator.GenerateMenuItems();
        }

        public Task AddAsync(MenuItem entity)
        {
            _menuItems.Add(entity);
            return Task.CompletedTask;
        }

        public Task DeleteAsync(Guid id)
        {
            _menuItems.RemoveAll(m => m.Id == (ID)id);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<MenuItem>> GetAllAsync()
        {
            return Task.FromResult(_menuItems.AsEnumerable());
        }

        public Task<MenuItem> GetAsync(Guid id)
        {
            return Task.FromResult(_menuItems.FirstOrDefault(m => m.Id == (ID)id));
        }

        public Task UpdateAsync(MenuItem entity)
        {
            return Task.CompletedTask;
        }
    }
}