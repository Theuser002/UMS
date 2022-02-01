using System;
using System.ComponentModel.DataAnnotations;
using UMS.Data;

namespace UMS.Models
{
    public class LeaveRequestDto : CreateLeaveRequestDto
    {
        public int Id { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public LeaveStatusDto LeaveStatus { get; set; }
    }
}
