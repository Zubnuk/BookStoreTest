using BookStoreTest.Data;
using BookStoreTest.Models;
using BookStoreTest.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BookStoreTest.Repositories
{
    public class RolesRepository : IBaseRepository<Role>
    {
        ApplicationDbContext context;
        public RolesRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task AddAsync(Role entity, CancellationToken cancellationToken = default)
        {
            await context.Roles.AddAsync(entity, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);
        }

        public async Task<bool> DeleteByIdAsync(int id, CancellationToken cancellationToken)
        {
            Role role = await GetByIdAsync(id, cancellationToken);
            if (role == null) return false;
            context.Roles.Remove(role);
            await context.SaveChangesAsync(cancellationToken);
            return true;
        }



        public async Task<IEnumerable<Role>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await context.Roles.ToListAsync(cancellationToken);
        }

        public async Task<Role?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return await context.Roles.FirstOrDefaultAsync(role => role.IdRole == id, cancellationToken);
        }



        public async Task<Role> UpdateAsync(Role entity, CancellationToken cancellationToken = default)
        {
            context.Roles.Update(entity);
            await context.SaveChangesAsync(cancellationToken);
            return entity;
        }

        
    }
}
