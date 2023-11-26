using BookStore.API.Models;
using BookStore.API.DAL.Contracts;
using BookStore.API.Services.Contracts;

namespace BookStore.API.Services;

public abstract class CrudBaseService<TEntity> : ICrudBaseService<TEntity> where TEntity : BaseEntity
{
    private readonly ICrudBaseRepository<TEntity> _repository;

    public CrudBaseService(ICrudBaseRepository<TEntity> repository)
    {
        _repository = repository;
    }

    public async Task<List<TEntity>> GetListAsync() =>
        await _repository.GetListAsync();

    public async Task<TEntity?> GetAsync(string id) =>
        await _repository.GetAsync(id);

    public async Task AddAsync(TEntity newItem) =>
        await _repository.AddAsync(newItem);

    public async Task UpdateAsync(string id, TEntity updatedItem) =>
        await _repository.UpdateAsync(id, updatedItem);

    public async Task RemoveAsync(string id) =>
        await _repository.RemoveAsync(id);
}