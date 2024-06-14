using BookStoreTest.Data;
using BookStoreTest.Models;
using BookStoreTest.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BookStoreTest.Repositories
{
    public class BooksRepository : IBaseRepository<Cart>
    {
        ApplicationDbContext context;
        public BooksRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task AddAsync(Cart entity, CancellationToken cancellationToken = default)
        {
            await context.Carts.AddAsync(entity, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);
        }

        public async Task<bool> DeleteByIdAsync(int id, CancellationToken cancellationToken)
        {
            Cart cart = await GetByIdAsync(id, cancellationToken);
            if (cart == null) return false;
            context.Carts.Remove(cart);
            await context.SaveChangesAsync(cancellationToken);
            return true;
        }



        public async Task<IEnumerable<Cart>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await context.Carts.ToListAsync(cancellationToken);
        }

        public async Task<Cart?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return await context.Carts.FirstOrDefaultAsync(cart => cart.IdCart == id, cancellationToken);
        }


        async Task<Cart> IBaseRepository<Cart>.UpdateAsync(Cart entity, CancellationToken cancellationToken)
        {
            context.Carts.Update(entity);
            await context.SaveChangesAsync(cancellationToken);
            return entity;
        }
    }
}
