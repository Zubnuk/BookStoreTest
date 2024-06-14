using BookStoreTest.Data;
using BookStoreTest.Models;
using BookStoreTest.Repositories.Interfaces;

using Microsoft.EntityFrameworkCore;

namespace BookStoreTest.Repositories
{
    public class OrdersRepository : IBaseRepository<Order>
    {
        ApplicationDbContext context;
        public OrdersRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task AddAsync(Order entity, CancellationToken cancellationToken = default)
        {
            await context.Orders.AddAsync(entity, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);
        }

        public async Task<bool> DeleteByIdAsync(int id, CancellationToken cancellationToken)
        {
            Order order = await GetByIdAsync(id, cancellationToken);
            if (order == null) return false;
            context.Orders.Remove(order);
            await context.SaveChangesAsync(cancellationToken);
            return true;
        }



        public async Task<IEnumerable<Order>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await context.Orders.ToListAsync(cancellationToken);
        }

        public async Task<Order?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return await context.Orders.FirstOrDefaultAsync(order => order.IdOrder == id, cancellationToken);
        }



        public async Task<Order> UpdateAsync(Order entity, CancellationToken cancellationToken = default)
        {
            context.Orders.Update(entity);
            await context.SaveChangesAsync(cancellationToken);
            return entity;
        }

        
    }
}
