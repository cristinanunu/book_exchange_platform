using bookExchange.Api.Data;
using bookExchange.Api.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;

namespace bookExchange.Api.Services;

public class HapiBookService : IHapiBookService
{
    public async Task<List<Book>> GetBooksFromApi()
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://hapi-books.p.rapidapi.com/top/2021"),
            Headers =
            {
                { "X-RapidAPI-Key", "fe1b677b52msh643bc2925d110f0p184f12jsn8ed8ab9e7b41" },
                { "X-RapidAPI-Host", "hapi-books.p.rapidapi.com" },
            },
        };
        var response = await client.SendAsync(request);
        response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            var myBooksList = JsonConvert.DeserializeObject<List<HapiApiBook>>(body);
            Console.WriteLine("this is from console" + myBooksList);
            //mapping
            return myBooksList.Select(book => new Book
            {
                Name = book.Name,
                Category = book.Category,
                ImageUrl = book.Cover,
                AddedAt = DateTime.Now
            }).ToList();
    }
}