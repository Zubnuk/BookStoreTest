namespace BookStoreTest.Repositories.Interfaces
{
    public interface IBaseRepositoryDoubleKey<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<T?> GetByIdAsync(int idFirst,int idSecond, CancellationToken cancellationToken = default);
        Task AddAsync(T entity, CancellationToken cancellationToken = default);
        Task<T> UpdateAsync(T entity, CancellationToken cancellationToken = default);
        Task<bool> DeleteByIdAsync(int idFirst, int idSecond, CancellationToken cancellationToken);
    }
}
