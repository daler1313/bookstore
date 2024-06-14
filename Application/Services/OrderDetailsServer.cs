using Domain.Entity;
using Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class OrderDetailsServer : IBaseService<OrderDetails>
    {
        private readonly IBaseRepository<OrderDetails> _entityRepository;
        public OrderDetailsServer(IBaseRepository<OrderDetails> entityRepository) { _entityRepository = entityRepository; }
        public async Task<OrderDetails> CreateAsync(OrderDetails entity, CancellationToken token = default)
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

        public async Task<IEnumerable<OrderDetails>> GetAllAsync(CancellationToken token = default)
        {
            return await _entityRepository.GetAllAsync(token);
        }

        public async Task<OrderDetails> GetAsync(int id, CancellationToken token = default)
        {
            return await _entityRepository.GetAsync(id, token);
        }

        public async Task<bool> UpdateAsync(OrderDetails entity, CancellationToken token = default)
        {
            var Entity = await GetAsync(entity.Id);

            if (Entity is null)
            {
                return false;
            }
            Entity.TotalPrice = entity.TotalPrice;
            Entity.Quantity = entity.Quantity;
            return await _entityRepository.UpdateAsync(Entity, token);
        }
    }
}
