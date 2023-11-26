using BookStore.API.Models;
using BookStore.API.Repositories;

namespace BookStore.API.Services;

public class BookService : BaseService<Book>
{
    public BookService(MyMongoRepository repository) : base(repository)
    {
    }
}