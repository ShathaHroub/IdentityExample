using System.ComponentModel.DataAnnotations;

namespace Identitynext2.Models.ViewModel
{
    public class EditRoleViewModel
    {
        public EditRoleViewModel()
        {
            Users = new List<string>();
        }

        public string? RoleId { get; set; }

        [Required(ErrorMessage ="Enter Role Name")]
        [MinLength(3,ErrorMessage ="3 Characters minimum")]
        [MaxLength(25,ErrorMessage ="25 char max")]
        public string? RoleName { get; set; }

        public List<string> Users { get; set; }

    }
}
