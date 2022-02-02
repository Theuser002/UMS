using System.ComponentModel.DataAnnotations;

namespace UMS.Models
{
    public class CreateUserDto : LoginUserDto
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required]
        public string Role { get; set; }
    }
}
