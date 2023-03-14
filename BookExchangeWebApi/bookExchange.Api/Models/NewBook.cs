using System.ComponentModel.DataAnnotations;

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
    
    [DataType(DataType.Date)]
    public DateTime AddedAt { get; set; }
}