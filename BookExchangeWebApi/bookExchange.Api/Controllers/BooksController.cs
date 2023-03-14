using bookExchange.Api.Data;
using bookExchange.Api.Models;
using bookExchange.Api.Repositories;
using bookExchange.Api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bookExchange.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BooksContext _context;
        private readonly IHapiBookService _bookService;
        private readonly IBookRepository _repositoriesBookRepository;

        public BooksController(BooksContext context, IHapiBookService bookService, IBookRepository bookRepository)
        {
            _context = context;
            _bookService = bookService;
            _repositoriesBookRepository = bookRepository;
        }

        // GET: api/Books
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBook(string? userName, string? category)
        {
          if (_context.Book == null)
          {
              return NotFound();
          }
          var booksFromDb = await _context.Book
              .Include(book => book.User).ToListAsync();

          if (booksFromDb.Count == 0)
          {
              var booksFromApi = await _bookService.GetBooksFromApi();
              foreach (var book in booksFromApi)
              {
                  _context.Book.Add(book);
              }
              await _context.SaveChangesAsync();
              booksFromDb = await _context.Book.ToListAsync();
          }
          
          if (!string.IsNullOrEmpty(category))
          {
              return _context.Book
                  .Where(book => book.Category != null && book.Category == category)
                  .ToList();
          }

          return booksFromDb;
        }

        // GET: api/Books/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
          if (_context.Book == null)
          {
              return NotFound();
          }
            var book = await _context.Book.FindAsync(id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }

        // PUT: api/Books/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBook(int id, Book book)
        {
            if (id != book.Id)
            {
                return BadRequest();
            }

            _context.Entry(book).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
        
        [HttpPut("{id}/user")]
        public async Task<ActionResult<Book>> PutUserForBook(int id, [FromBody] User user)
        {
            var bookFromDb = _context.Book.FirstOrDefault(book => book.Id == id);

            if (bookFromDb == null)
            {
                return NotFound();
            }
            if (string.IsNullOrEmpty(user.Name))
            {
                return BadRequest("User cannot be null or empty.");
            }
            
            var userFromDb = _context.User.Find(user.Id);
            
            if (userFromDb == null)
            {
                userFromDb = _context.User.Add(new User { Name = user.Name, Email = user.Email}).Entity;
            }

            bookFromDb.User = userFromDb;

            await _context.SaveChangesAsync();

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return bookFromDb;
            //NoContent();
        }

        // POST: api/Books
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Book>> PostBook(NewBook book)
        {
          if (_context.Book == null)
          {
              return Problem("Entity set 'BooksContext.Book'  is null.");
          }

          var saveBook = _context.Book.Add(new Book
              {
                  Name = book.Name,
                  Category = book.Category,
                  ImageUrl = book.ImageUrl,
                  AddedAt = book.AddedAt
              });

            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBook", new { id = saveBook.Entity.Id }, saveBook.Entity);
        }

            // DELETE: api/Books/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            if (_context.Book == null)
            {
                return NotFound();
            }
            var book = await _context.Book.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            _context.Book.Remove(book);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BookExists(int id)
        {
            return (_context.Book?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
