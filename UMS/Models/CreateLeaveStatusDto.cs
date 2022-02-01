using System.ComponentModel.DataAnnotations;

namespace UMS.Models
{
    public class CreateLeaveStatusDto
    {
        [Required]
        public string Name { get; set; }
    }
}
