using BookStoreTest.Data;
using BookStoreTest.Models;
using BookStoreTest.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BookStoreTest.Repositories
{
    public class BookAuthorsRepository : IBaseRepositoryDoubleKey<BookAuthor>
    {
        ApplicationDbContext context;
        public BookAuthorsRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task AddAsync(BookAuthor entity, CancellationToken cancellationToken = default)
        {
            await context.BookAuthors.AddAsync(entity, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);
        }


        public async Task<bool> DeleteByIdAsync(int idFirst, int idSecond, CancellationToken cancellationToken)
        {
            BookAuthor author = await GetByIdAsync(idFirst, idSecond, cancellationToken);
            if (author == null) return false;
            context.BookAuthors.Remove(author);
            await context.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<IEnumerable<BookAuthor>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await context.BookAuthors.ToListAsync(cancellationToken);
        }

        public async Task<BookAuthor?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return await context.BookAuthors.FirstOrDefaultAsync(
            author => author.IdAuthor == id && author.IdBook == id,
            cancellationToken);
        }

        public Task<BookAuthor?> GetByIdAsync(int idFirst, int idSecond, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<BookAuthor> UpdateAsync(BookAuthor entity, CancellationToken cancellationToken = default)
        {
            context.BookAuthors.Update(entity);
            await context.SaveChangesAsync(cancellationToken);
            return entity;
        }

        
    }
}
