using BookStoreTest.Data;
using BookStoreTest.Models;
using BookStoreTest.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BookStoreTest.Repositories
{
    public class BookGenresRepository : IBaseRepositoryDoubleKey<BookGenre>
    {
        ApplicationDbContext context;
        public BookGenresRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(BookGenre entity, CancellationToken cancellationToken = default)
        {
            await context.BookGenres.AddAsync(entity, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);
        }

       

        public async Task<bool> DeleteByIdAsync(int idFirst, int idSecond, CancellationToken cancellationToken)
        {
            throw new NotImplementedException(); BookGenre bookGenre = await GetByIdAsync(idFirst,idSecond, cancellationToken);
            if (bookGenre == null) return false;
            context.BookGenres.Remove(bookGenre);
            await context.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<IEnumerable<BookGenre>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await context.BookGenres.ToListAsync(cancellationToken);
        }


        public async Task<BookGenre?> GetByIdAsync(int idFirst, int idSecond, CancellationToken cancellationToken = default)
        {
            return await context.BookGenres.FirstOrDefaultAsync(
            bookGenre => bookGenre.IdGenre == idFirst && bookGenre.IdBook == idSecond,
            cancellationToken);
        }

        public async Task<BookGenre> UpdateAsync(BookGenre entity, CancellationToken cancellationToken = default)
        {
            context.BookGenres.Update(entity);
            await context.SaveChangesAsync(cancellationToken);
            return entity;
        }

       
    }
}
