using bookExchange.Api.Data;
using bookExchange.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace bookExchange.Api.Repositories;

public class BookRepository : IBookRepository
{
    private readonly BooksContext _dbContext;

    public BookRepository(BooksContext dbContext)
    {
        _dbContext = dbContext;
    }
    public IEnumerable<Book> GetAll(string? user)
    {
        return _dbContext.Book.Include(book => book.User).ToList();

    }

    public Book? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Book Create(Book book)
    {
        throw new NotImplementedException();
    }

    public Book UpdateCd(Book book)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }
}