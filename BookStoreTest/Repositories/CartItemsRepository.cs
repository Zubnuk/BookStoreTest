using BookStoreTest.Data;
using BookStoreTest.Models;
using BookStoreTest.Repositories.Interfaces;
using DocumentFormat.OpenXml.Bibliography;
using Microsoft.EntityFrameworkCore;

namespace BookStoreTest.Repositories
{
    public class CartItemsRepository : IBaseRepository<CartItem>
    {
        ApplicationDbContext context;
        public CartItemsRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task AddAsync(CartItem entity, CancellationToken cancellationToken = default)
        {
            await context.CartItems.AddAsync(entity, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);
        }


        public async Task<bool> DeleteByIdAsync(int id, CancellationToken cancellationToken)
        {
            CartItem cart = await GetByIdAsync(id, cancellationToken);
            if (cart == null) return false;
            context.CartItems.Remove(cart);
            await context.SaveChangesAsync(cancellationToken);
            return true;
        }

        

        public async Task<IEnumerable<CartItem>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await context.CartItems.ToListAsync(cancellationToken);
        }

        public async Task<CartItem?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return await context.CartItems.FirstOrDefaultAsync(cart => cart.IdCartItem == id, cancellationToken);
        }

        public Task<CartItem?> GetByIdAsync(int idFirst, int idSecond, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<CartItem> UpdateAsync(CartItem entity, CancellationToken cancellationToken = default)
        {
            context.CartItems.Update(entity);
            await context.SaveChangesAsync(cancellationToken);
            return entity;
        }

        

        
    }
}
