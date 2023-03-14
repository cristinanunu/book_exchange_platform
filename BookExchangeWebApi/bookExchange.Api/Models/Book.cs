using System.ComponentModel.DataAnnotations;

namespace bookExchange.Api.Models;

public class Book
{
    public int Id { get; set; }
    
    [Required]
    [MinLength(3)]
    public string Name { get; set; }
    
    [Required]
    public string Category { get; set; }
    public string ImageUrl { get; set; }
    
    [DataType(DataType.Date)]
    public DateTime AddedAt { get; set; }
    
    public User? User { get; set; }
}