using System.ComponentModel.DataAnnotations;

namespace UMS.Models
{
    public class CreateLeaveTypeDto
    {
        [Required]
        public string Name { get; set; }
    }
}
