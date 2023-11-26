using MongoDB.Driver;
using BookStore.API.Models;
using Microsoft.Extensions.Options;

namespace BookStore.API.Repositories;

public class MyMongoRepository
{
    public IMongoDatabase mongoDatabase;

    public MyMongoRepository(
        IOptions<DatabaseSettings> dabaseSettings)
    {
        var mongoClient = new MongoClient(dabaseSettings.Value.ConnectionString);
        mongoDatabase = mongoClient.GetDatabase(dabaseSettings.Value.DatabaseName);
    }
}