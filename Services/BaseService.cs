using MongoDB.Driver;
using BookStore.API.Models;
using BookStore.API.Repositories;

namespace BookStore.API.Services;

public class BaseService<T> where T : BaseEntity
{
    private readonly IMongoCollection<T> _collection;

    public BaseService(MyMongoRepository myRepository)
    {
        string className = typeof(T).Name;
        _collection = myRepository.mongoDatabase.GetCollection<T>(className);
    }

    public async Task<List<T>> GetListAsync() =>
        await _collection.Find(_ => true).ToListAsync();

    public async Task<T?> GetAsync(string id) =>
        await _collection.Find(x => x.Id == id).FirstOrDefaultAsync();

    public async Task CreateAsync(T newItem) =>
        await _collection.InsertOneAsync(newItem);

    public async Task UpdateAsync(string id, T updatedItem) =>
        await _collection.ReplaceOneAsync(x => x.Id == id, updatedItem);

    public async Task RemoveAsync(string id) => await _collection.DeleteOneAsync(x => x.Id == id);
}