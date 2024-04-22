using Meno.Core.Entities;
using Meno.Core.ValueObjects;
using Meno.Infrastructure.Abstractions;

namespace Meno.Infrastructure.DAL.Repositories.InMemory
{
    public class InMemoryMenuRepository : IRepository<Menu>
    {
        private readonly List<Menu> _menus;

        public InMemoryMenuRepository()
        {
            _menus = FakeDataGenerator.GenerateMenus();
        }

        public Task AddAsync(Menu entity)
        {
            _menus.Add(entity);
            return Task.CompletedTask;
        }

        public Task DeleteAsync(Guid id)
        {
            _menus.RemoveAll(m => m.Id == (ID)id);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<Menu>> GetAllAsync()
        {
            return Task.FromResult(_menus.AsEnumerable());
        }

        public Task<Menu> GetAsync(Guid id)
        {
            return Task.FromResult(_menus.FirstOrDefault(m => m.Id == (ID)id));
        }

        public Task UpdateAsync(Menu entity)
        {
            return Task.CompletedTask;
        }
    }
}