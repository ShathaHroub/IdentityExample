using System.ComponentModel.DataAnnotations;

namespace Identitynext2.Models.ViewModel
{
    public class RegisterViewModel
    {

        [Required(ErrorMessage = "Enter email please")]
        [MaxLength(40, ErrorMessage = "40 Character max")]
        [EmailAddress(ErrorMessage = "Example: Shatha@outlook.com")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Enter password please")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Required(ErrorMessage = "Confirm your password please")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Password does not match")]
        public string? ConfirmPassword { get; set; }

        public string? Mobile { get; set; }

    }
}
