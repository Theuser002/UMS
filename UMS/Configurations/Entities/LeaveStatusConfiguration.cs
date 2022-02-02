using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UMS.Data;

namespace UMS.Configurations.Entities
{
    public class LeaveStatusConfiguration : IEntityTypeConfiguration<LeaveStatus>
    {
        public void Configure(EntityTypeBuilder<LeaveStatus> builder)
        {
            builder.HasData(
                    new LeaveType
                    {
                        Id = 1,
                        Name = "Approved"
                    },
                    new LeaveType
                    {
                        Id = 2,
                        Name = "Denied"
                    },
                    new LeaveType
                    {
                        Id = 3,
                        Name = "Pending"
                    }
                );
        }
    }
}
