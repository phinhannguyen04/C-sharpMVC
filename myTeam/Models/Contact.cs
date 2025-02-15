using System.ComponentModel.DataAnnotations;

namespace myTeam.Models
{
    public class Contact
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "The name must not be longer than 50 characters")]
        public string? Name { get; set; }
        
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string? Email { get; set; }
        public string? Title { get; set; } = "Mail Contact";
        
        [Required(ErrorMessage = "Message is required")]
        [MinLength(10, ErrorMessage = "The message must be at least 10 characters long")]
        public string Message { get; set; }    
        public DateTime DateTime { get; set; } = DateTime.UtcNow;
        public bool IsRead { get; set; } = false;
    }
}
