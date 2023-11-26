using MongoDB.Driver;
using BookStore.API.Models;
using BookStore.API.DAL.Contracts;
using Microsoft.Extensions.Options;

namespace BookStore.API.DAL.Repositories;

public abstract class CrudBaseRepository<TEntity> : ICrudBaseRepository<TEntity> where TEntity : BaseEntity
{
    private readonly IMongoCollection<TEntity> _collection;

    public CrudBaseRepository(IOptions<DatabaseSettings> dabaseSettings)
    {
        var client = new MongoClient(dabaseSettings.Value.ConnectionString);
        var database = client.GetDatabase(dabaseSettings.Value.DatabaseName);
        _collection = database.GetCollection<TEntity>(typeof(TEntity).Name);
    }

    public async Task<List<TEntity>> GetListAsync() =>
        await _collection.Find(_ => true).ToListAsync();

    public async Task<TEntity?> GetAsync(string id) =>
        await _collection.Find(x => x.Id == id).FirstOrDefaultAsync();

    public async Task AddAsync(TEntity newItem) =>
        await _collection.InsertOneAsync(newItem);

    public async Task UpdateAsync(string id, TEntity updatedItem) =>
        await _collection.ReplaceOneAsync(x => x.Id == id, updatedItem);

    public async Task RemoveAsync(string id) =>
        await _collection.DeleteOneAsync(x => x.Id == id);
}