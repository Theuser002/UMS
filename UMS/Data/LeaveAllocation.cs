using System.ComponentModel.DataAnnotations.Schema;

namespace UMS.Data
{
    public class LeaveAllocation
    {
        public string Id { get; set; }

        [ForeignKey(nameof(ApiUser))]
        public string UserId { get; set; }
        public ApiUser ApiUser { get; set; }

        public string Year { get; set; }
        public double TotalAmount { get; set; }
        public double UsedAmount { get; set; }
    }
}
