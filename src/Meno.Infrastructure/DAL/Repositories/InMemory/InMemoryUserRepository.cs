using Meno.Core.Entities;
using Meno.Core.ValueObjects;
using Meno.Infrastructure.Abstractions;

namespace Meno.Infrastructure.DAL.Repositories.InMemory
{
    public class InMemoryUserRepository : IRepository<User>
    {
        private readonly List<User> _users;

        public InMemoryUserRepository()
        {
            _users = FakeDataGenerator.GenerateUsers();
        }

        public Task AddAsync(User entity)
        {
            _users.Add(entity);
            return Task.CompletedTask;
        }

        public Task DeleteAsync(Guid id)
        {
            _users.RemoveAll(u => u.Id == (ID)id);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            return Task.FromResult(_users.AsEnumerable());
        }

        public Task<User> GetAsync(Guid id)
        {
            return Task.FromResult(_users.FirstOrDefault(u => u.Id == (ID)id));
        }

        public Task UpdateAsync(User entity)
        {
            return Task.CompletedTask;
        }
    }
}