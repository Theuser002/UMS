using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UMS.Data;

namespace UMS.Configurations.Entities
{
    public class LeaveTypeConfiguration : IEntityTypeConfiguration<LeaveType>
    {
        public void Configure(EntityTypeBuilder<LeaveType> builder)
        {
            builder.HasData(
                    new LeaveType
                    {
                        Id = 1,
                        Name = "Sick Leave"
                    },
                    new LeaveType
                    {
                        Id = 2,
                        Name = "Personal Leave"
                    },
                    new LeaveType
                    {
                        Id = 3,
                        Name = "Vacation Leave"
                    }
                );
        }
    }
}
