using BookStore.API.Models;
using BookStore.API.DAL.Contracts;
using Microsoft.Extensions.Options;

namespace BookStore.API.DAL.Repositories;

public class BookRepository : CrudBaseRepository<Book>, IBookRepository
{
    public BookRepository(IOptions<DatabaseSettings> dabaseSettings) : base(dabaseSettings)
    {
    }
}