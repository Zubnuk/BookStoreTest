using BookStoreTest.Data;
using BookStoreTest.Models;
using BookStoreTest.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BookStoreTest.Repositories
{
    public class SellersRepository : IBaseRepository<Seller>
    {
        ApplicationDbContext context;
        public SellersRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task AddAsync(Seller entity, CancellationToken cancellationToken = default)
        {
            await context.Sellers.AddAsync(entity, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);
        }

        public async Task<bool> DeleteByIdAsync(int id, CancellationToken cancellationToken)
        {
            Seller seller = await GetByIdAsync(id, cancellationToken);
            if (seller == null) return false;
            context.Sellers.Remove(seller);
            await context.SaveChangesAsync(cancellationToken);
            return true;
        }



        public async Task<IEnumerable<Seller>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await context.Sellers.ToListAsync(cancellationToken);
        }

        public async Task<Seller?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return await context.Sellers.FirstOrDefaultAsync(seller => seller.IdSeller == id, cancellationToken);
        }



        public async Task<Seller> UpdateAsync(Seller entity, CancellationToken cancellationToken = default)
        {
            context.Sellers.Update(entity);
            await context.SaveChangesAsync(cancellationToken);
            return entity;
        }

      
    }
}
