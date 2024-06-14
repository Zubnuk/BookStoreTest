using BookStoreTest.Data;
using BookStoreTest.Models;
using BookStoreTest.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BookStoreTest.Repositories
{
    public class GenresRepository : IBaseRepository<Genre>
    {
        ApplicationDbContext context;
        public GenresRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task AddAsync(Genre entity, CancellationToken cancellationToken = default)
        {
            await context.Genres.AddAsync(entity, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);
        }

        public async Task<bool> DeleteByIdAsync(int id, CancellationToken cancellationToken)
        {
            Genre genre = await GetByIdAsync(id, cancellationToken);
            if (genre == null) return false;
            context.Genres.Remove(genre);
            await context.SaveChangesAsync(cancellationToken);
            return true;
        }



        public async Task<IEnumerable<Genre>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await context.Genres.ToListAsync(cancellationToken);
        }

        public async Task<Genre?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return await context.Genres.FirstOrDefaultAsync(genre => genre.IdGenre == id, cancellationToken);
        }



        public async Task<Genre> UpdateAsync(Genre entity, CancellationToken cancellationToken = default)
        {
            context.Genres.Update(entity);
            await context.SaveChangesAsync(cancellationToken);
            return entity;
        }

        
    }
}
