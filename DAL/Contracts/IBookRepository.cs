using BookStore.API.Models;

namespace BookStore.API.DAL.Contracts;

public interface IBookRepository : ICrudBaseRepository<Book>
{
}