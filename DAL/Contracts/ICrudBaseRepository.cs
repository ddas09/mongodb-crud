using BookStore.API.Models;

namespace BookStore.API.DAL.Contracts;

public interface ICrudBaseRepository<TEntity> where TEntity : BaseEntity
{
    Task<List<TEntity>> GetListAsync();

    Task<TEntity?> GetAsync(string id);

    Task AddAsync(TEntity newEntity);

    Task UpdateAsync(string id, TEntity updatedEntity);

    Task RemoveAsync(string id);
}