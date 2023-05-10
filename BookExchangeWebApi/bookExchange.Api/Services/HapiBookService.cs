using bookExchange.Api.Models;
using Newtonsoft.Json;
using DotNetEnv;

namespace bookExchange.Api.Services;

public class HapiBookService : IHapiBookService
{
    public async Task<List<Book>> GetBooksFromApi()
    {
        Env.Load();
        string? apiKey = Environment.GetEnvironmentVariable("API_KEY");
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://hapi-books.p.rapidapi.com/top/2021"),
            //add api keys

            Headers =
            {
                {"X-RapidAPI-Key", apiKey},
                { "X-RapidAPI-Host", "hapi-books.p.rapidapi.com" }
            }
        };
        var response = await client.SendAsync(request);
        response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            var myBooksList = JsonConvert.DeserializeObject<List<HapiApiBookRequest>>(body);
            Console.WriteLine("this is from console" + myBooksList);
            //mapping
            var booksFromApi = myBooksList.Select(book => new Book
            {
                Name = book.Name,
                Category = book.Category,
                ImageUrl = book.Cover,
                AddedAt = DateTime.Now
            }).ToList();
            return booksFromApi;
    }
}