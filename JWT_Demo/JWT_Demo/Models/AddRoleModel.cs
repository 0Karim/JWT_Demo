using System.ComponentModel.DataAnnotations;

namespace JWT_Demo.Models
{
    public class AddRoleModel
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        public string Role { get; set; }
    }
}
