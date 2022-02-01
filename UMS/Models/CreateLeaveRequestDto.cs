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
        public string Remarks { get; set; }

        [Required]
        public int LeaveTypeId { get; set; }

        [Required]
        public int LeaveStatusId { get; set; }
    }
}
