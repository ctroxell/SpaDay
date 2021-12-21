using System.ComponentModel.DataAnnotations;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Username needs to be 5-15 characters long.")]
        public string Username { get; set; } //required, 5-15 characters
        [Required]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password needs to be 6-20 characters long.")]
        public string Password { get; set; } // required, 6-20 characters
        [EmailAddress]
        public string Email { get; set; } // if provided must be in email format
        [Required]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password needs to be 6-20 characters long.")]
        public string VerifyPassword { get; set; } //required
    }
}
