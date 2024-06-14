using Domain.Entity;
using Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class GenreServer : IBaseService<Genre>
    {
        private readonly IBaseRepository<Genre> _entityRepository;
        public GenreServer(IBaseRepository<Genre> entityRepository) { _entityRepository = entityRepository; }

        public async Task<Genre> CreateAsync(Genre entity, CancellationToken token = default)
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

        public async Task<IEnumerable<Genre>> GetAllAsync(CancellationToken token = default)
        {
            return await _entityRepository.GetAllAsync(token);
        }

        public async Task<Genre> GetAsync(int id, CancellationToken token = default)
        {
            return await _entityRepository.GetAsync(id, token);
        }

        public async Task<bool> UpdateAsync(Genre entity, CancellationToken token = default)
        {

            var Entity = await GetAsync(entity.Id);

            if (Entity is null)
            {
                return false;
            }
            Entity.Name = entity.Name;
            Entity.Description = entity.Description;
            return await _entityRepository.UpdateAsync(Entity, token);

        }
    }
}
