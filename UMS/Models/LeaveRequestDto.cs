using System;
using System.ComponentModel.DataAnnotations;
using UMS.Data;

namespace UMS.Models
{
    public class LeaveRequestDto
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Note { get; set; }
        public string Remarks { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public LeaveStatusDto LeaveStatus { get; set; }
        public string UserId { get; set; }
    }
}
