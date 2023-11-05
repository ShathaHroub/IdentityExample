using System.ComponentModel.DataAnnotations;

namespace Identitynext2.Models.ViewModel
{
    public class CreateRoleViewModel
    {
        [Required]
        public string? RoleName { get; set; }


    }
} 
