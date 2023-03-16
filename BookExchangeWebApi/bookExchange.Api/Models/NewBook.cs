using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bookExchange.Api.Models;

public class NewBook
{
    [Required]
    [StringLength(50, 
        ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 3)]
    public string Name { get; set; }
    
    [Required]
    public string Category { get; set; }
    public string ImageUrl { get; set; }
    
    [Column(TypeName = "date")]
    public DateTime AddedAt { get; set; }
}