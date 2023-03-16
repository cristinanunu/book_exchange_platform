using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
    
    [Column(TypeName = "date")]
    public DateTime AddedAt { get; set; }
    
    public User? User { get; set; }
}