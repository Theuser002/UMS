using System;

namespace UMS.Data
{
    public class LeaveRequest
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Note { get; set; }
        public string Remarks { get; set; }

        public int LeaveTypeId { get; set; }
        public LeaveType LeaveType { get; set; }

        public int LeaveStatusId { get; set; }
        public LeaveStatus LeaveStatus { get; set; }
    }
}
