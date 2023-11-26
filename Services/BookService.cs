using BookStore.API.Models;
using BookStore.API.DAL.Contracts;
using BookStore.API.Services.Contracts;

namespace BookStore.API.Services;

public class BookService : CrudBaseService<Book>, IBookService
{
    public BookService(IBookRepository repository) : base(repository)
    {
    }
}