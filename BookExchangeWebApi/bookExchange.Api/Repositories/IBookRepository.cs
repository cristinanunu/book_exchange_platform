using bookExchange.Api.Models;

namespace bookExchange.Api.Repositories;

public interface IBookRepository
{
    IEnumerable<Book> GetAll(string? user);
    Book? GetById(int id);
    Book Create(Book book);
    Book UpdateCd(Book book);
    void Delete(int id);
}