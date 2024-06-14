using BookStoreTest.Data;
using BookStoreTest.Models;
using BookStoreTest.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BookStoreTest.Repositories
{
    public class PricesChangedRepository : IBaseRepository<PriceChanged>
    {
        ApplicationDbContext context;
        public PricesChangedRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task AddAsync(PriceChanged entity, CancellationToken cancellationToken = default)
        {
            await context.PriceChanged.AddAsync(entity, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);
        }

        public async Task<bool> DeleteByIdAsync(int id, CancellationToken cancellationToken)
        {
            PriceChanged priceChanged = await GetByIdAsync(id, cancellationToken);
            if (priceChanged == null) return false;
            context.PriceChanged.Remove(priceChanged);
            await context.SaveChangesAsync(cancellationToken);
            return true;
        }



        public async Task<IEnumerable<PriceChanged>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await context.PriceChanged.ToListAsync(cancellationToken);
        }

        public async Task<PriceChanged?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return await context.PriceChanged.FirstOrDefaultAsync(priceChanged => priceChanged.IdPriceChanged == id, cancellationToken);
        }



        public async Task<PriceChanged> UpdateAsync(PriceChanged entity, CancellationToken cancellationToken = default)
        {
            context.PriceChanged.Update(entity);
            await context.SaveChangesAsync(cancellationToken);
            return entity;
        }

        
    }
}
