using System.ComponentModel.DataAnnotations;

namespace Identitynext2.Models.ViewModel
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Enter email please")]
        [MaxLength(40, ErrorMessage = "40 Character max")]
        [EmailAddress(ErrorMessage = "Example: Shatha@outlook.com")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Enter password please")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        public bool RememberMe { get; set; }

    }
}
