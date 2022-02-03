using System;
using System.ComponentModel.DataAnnotations;
using UMS.Data;

namespace UMS.Models
{
    public class CreateLeaveRequestDto
    {
        [Required]
        public DateTime Start { get; set; }
        [Required]
        public DateTime End { get; set; }
        public string Note { get; set; }
        
        [Required]
        public int LeaveTypeId { get; set; }

        [Required]
        public string UserId { get; set; }
    }
}
