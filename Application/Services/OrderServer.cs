using Domain.Entity;
using Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class OrderServer : IBaseService<Order>
    {
        private readonly IBaseRepository<Order> _entityRepository;
        public OrderServer (IBaseRepository<Order> entityRepository) {_entityRepository = entityRepository;}
        public async Task<Order> CreateAsync(Order entity, CancellationToken token = default)
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

        public async Task<IEnumerable<Order>> GetAllAsync(CancellationToken token = default)
        {
            return await _entityRepository.GetAllAsync(token);
        }

        public async Task<Order> GetAsync(int id, CancellationToken token = default)
        {
            return await _entityRepository.GetAsync(id, token);
        }

        public async Task<bool> UpdateAsync(Order entity, CancellationToken token = default)
        {

            var Entity = await GetAsync(entity.Id);

            if (Entity is null)
            {
                return false;
            }
            Entity.Status = entity.Status;
            return await _entityRepository.UpdateAsync(Entity, token);
        }
    }
}
