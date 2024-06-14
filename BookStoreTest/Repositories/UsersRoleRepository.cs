using BookStoreTest.Data;
using BookStoreTest.Models;
using BookStoreTest.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BookStoreTest.Repositories
{
    public class UsersRoleRepository : IBaseRepositoryDoubleKey<UserRole>

    {
        ApplicationDbContext context;
        public UsersRoleRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(UserRole entity, CancellationToken cancellationToken = default)
        {
            await context.UserRoles.AddAsync(entity, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);
        }


        public async Task<bool> DeleteByIdAsync(int idFirst, int idSecond, CancellationToken cancellationToken)
        {
            UserRole author = await GetByIdAsync(idFirst, idSecond, cancellationToken);
            if (author == null) return false;
            context.UserRoles.Remove(author);
            await context.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<IEnumerable<UserRole>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await context.UserRoles.ToListAsync(cancellationToken);
        }

        public async Task<UserRole?> GetByIdAsync(int idFirst, int idSecond, CancellationToken cancellationToken = default)
        {
            return await context.UserRoles.FirstOrDefaultAsync(
            author => author.IdRole == idFirst && author.IdUser == idSecond,
            cancellationToken);
        }

        

        public async Task<UserRole> UpdateAsync(UserRole entity, CancellationToken cancellationToken = default)
        {
            context.UserRoles.Update(entity);
            await context.SaveChangesAsync(cancellationToken);
            return entity;
        }
    }
}
