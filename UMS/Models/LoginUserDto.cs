using System.ComponentModel.DataAnnotations;

namespace UMS.Models
{
    public class LoginUserDto
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
