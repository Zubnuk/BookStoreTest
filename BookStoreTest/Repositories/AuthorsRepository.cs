using BookStoreTest.Data;
using BookStoreTest.Models;
using BookStoreTest.Repositories.Interfaces;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.EntityFrameworkCore;

namespace BookStoreTest.Repositories
{
    public class AuthorsRepository : IBaseRepository<Models.Author>
     

    {
        ApplicationDbContext context;
        public AuthorsRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
       

        public async Task AddAsync(Models.Author entity, CancellationToken cancellationToken = default)
        {
            await context.Authors.AddAsync(entity, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);
        }

        public async Task<bool> DeleteByIdAsync(int id, CancellationToken cancellationToken)
        {
            Models.Author author = await GetByIdAsync(id, cancellationToken);
            if (author == null) return false;
            context.Authors.Remove(author);
            await context.SaveChangesAsync(cancellationToken);
            return true;
        }

       

        public async Task<IEnumerable<Models.Author>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await context.Authors.ToListAsync(cancellationToken);
        }

        public async Task<Models.Author?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return await context.Authors.FirstOrDefaultAsync(author => author.IdAuthor == id, cancellationToken);
        }

      

        public async Task<Models.Author> UpdateAsync(Models.Author entity, CancellationToken cancellationToken = default)
        {
            context.Authors.Update(entity);
            await context.SaveChangesAsync(cancellationToken);
            return entity;
        }

    }
}
