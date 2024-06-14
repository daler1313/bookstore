using Domain.Entity;
using Domain.Interfaces.Repositories;

namespace Application.Services
{
    public class AuthorService : IBaseService<Author>
    {   
        private readonly IBaseRepository<Author> _entityRepository;
        public AuthorService(IBaseRepository<Author> entityRepository) 
        {
            _entityRepository = entityRepository;
        }

        public async Task<Author> CreateAsync(Author entity, CancellationToken token = default)
        {
            return await _entityRepository.CreateAsync(entity, token);
        }

        public async Task<bool> DeleteAsync(int id, CancellationToken token = default)
        {
            var entity = await _entityRepository.GetAsync(id, token);

            if (entity == null)
                return false;

            return await _entityRepository.DeleteAsync(entity, token);
        }

        public async Task<IEnumerable<Author>> GetAllAsync(CancellationToken token = default)
        {
            return await _entityRepository.GetAllAsync(token);
        }

        public async Task<Author> GetAsync(int id, CancellationToken token = default)
        {
            return await _entityRepository.GetAsync(id, token);
        }

        public async Task<bool> UpdateAsync(Author entity, CancellationToken token = default)
        {
            var Entity = await GetAsync(entity.Id);

            if (Entity is null)
            {
                return false;
            }
            Entity.Name = entity.Name;
            Entity.Email = entity.Email;
            Entity.PhoneNumber = entity.PhoneNumber;
            Entity.Experience = entity.Experience;
            return await _entityRepository.UpdateAsync(Entity, token);
        }
    }
}
