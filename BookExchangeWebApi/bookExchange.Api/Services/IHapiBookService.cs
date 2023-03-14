using bookExchange.Api.Models;

namespace bookExchange.Api.Services;

public interface IHapiBookService
{
    Task<List<Book>> GetBooksFromApi();
}