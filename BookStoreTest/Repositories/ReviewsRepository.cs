using BookStoreTest.Data;
using BookStoreTest.Models;
using BookStoreTest.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BookStoreTest.Repositories
{
    public class ReviewsRepository : IBaseRepository<Review>
    {
        ApplicationDbContext context;
        public ReviewsRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task AddAsync(Review entity, CancellationToken cancellationToken = default)
        {
            await context.Reviews.AddAsync(entity, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);
        }

        public async Task<bool> DeleteByIdAsync(int id, CancellationToken cancellationToken)
        {
            Review review = await GetByIdAsync(id, cancellationToken);
            if (review == null) return false;
            context.Reviews.Remove(review);
            await context.SaveChangesAsync(cancellationToken);
            return true;
        }



        public async Task<IEnumerable<Review>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await context.Reviews.ToListAsync(cancellationToken);
        }

        public async Task<Review?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return await context.Reviews.FirstOrDefaultAsync(review => review.IdReview == id, cancellationToken);
        }



        public async Task<Review> UpdateAsync(Review entity, CancellationToken cancellationToken = default)
        {
            context.Reviews.Update(entity);
            await context.SaveChangesAsync(cancellationToken);
            return entity;
        }

        
    }
}
