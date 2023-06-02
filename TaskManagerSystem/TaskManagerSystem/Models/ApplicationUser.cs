using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TaskManagerSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Additional properties, if needed
        // For example, you can add custom user properties like FirstName, LastName, etc.
        // public string FirstName { get; set; }
        // public string LastName { get; set; }

        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        [Required]
        public string Priority { get; set; }

    }
}

