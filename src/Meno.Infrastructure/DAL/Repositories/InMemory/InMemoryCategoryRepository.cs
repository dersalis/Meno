using Meno.Core.Entities;
using Meno.Core.ValueObjects;
using Meno.Infrastructure.Abstractions;

namespace Meno.Infrastructure.DAL.Repositories.InMemory
{
    public class InMemoryCategoryRepository : IRepository<Category>
    {
        private readonly List<Category> _categories;

        public InMemoryCategoryRepository()
        {
            _categories = FakeDataGenerator.GenerateCategories();
        }

        public Task AddAsync(Category entity)
        {
            _categories.Add(entity);
            return Task.CompletedTask;
        }

        public Task DeleteAsync(Guid id)
        {
            _categories.RemoveAll(c => c.Id == (ID)id);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<Category>> GetAllAsync()
        {
            return Task.FromResult(_categories.AsEnumerable());
        }

        public Task<Category> GetAsync(Guid id)
        {
            return Task.FromResult(_categories.FirstOrDefault(c => c.Id == (ID)id));
        }

        public Task UpdateAsync(Category entity)
        {
            return Task.CompletedTask;
        }
    }
}