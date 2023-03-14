using System.ComponentModel.DataAnnotations;

namespace bookExchange.Api.Models;

public class NewUser
{
    [Required]
    [StringLength(50, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 3)]
    public string Name { get; set; }
    
    [StringLength(50)]
    public string? Email { get; set; }
}