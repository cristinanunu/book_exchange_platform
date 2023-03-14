using Bogus;
using bookExchange.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace bookExchange.Api.Data;

public class BooksContext : DbContext
{
    public BooksContext (DbContextOptions<BooksContext> options)
        : base(options)
    {
    }

    public DbSet<User> User { get; set; } = default!;

    public DbSet<Book> Book { get; set; } = default!;
        
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>()
            .HasOne(user => user.User);
        
        var ids = 1;
        var fakeUser = new Faker<User>()
            .RuleFor(m => m.Id, f => ids++)
            .RuleFor(m => m.Name, f => f.Name.FullName())
            .RuleFor(m => m.Email, (f, m) => f.Internet.Email(m.Name));
        
        modelBuilder
            .Entity<User>()
            .HasData(fakeUser.GenerateBetween(10, 10));
    }
}