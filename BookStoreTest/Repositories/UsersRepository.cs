using BookStoreTest.Data;
using BookStoreTest.Models;
using BookStoreTest.Repositories.Interfaces;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace BookStoreTest.Repositories
{
    public class UsersRepository : IBaseRepository<User>
    {
        ApplicationDbContext context;
        public UsersRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task AddAsync(User entity, CancellationToken cancellationToken = default)
        {
            await context.Users.AddAsync(entity, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);
            
        }

       

        public async Task<bool> DeleteByIdAsync(int id, CancellationToken cancellationToken)
        {
            User user = await GetByIdAsync(id, cancellationToken);
            if (user == null) return false;
            context.Users.Remove(user);
            await context.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<IEnumerable<User>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await context.Users.ToListAsync(cancellationToken);
        }

        public async Task<User?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return await context.Users.FirstOrDefaultAsync(users => users.IdUser == id, cancellationToken);
        }

        public async Task<User> UpdateAsync(User entity, CancellationToken cancellationToken = default)
        {
            context.Users.Update(entity);
            await context.SaveChangesAsync(cancellationToken);
            return entity;  
        }

        
    }
}
