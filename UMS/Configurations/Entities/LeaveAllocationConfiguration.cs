using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using UMS.Data;

namespace UMS.Configurations.Entities
{
    public class LeaveAllocationConfiguration : IEntityTypeConfiguration<LeaveAllocation>
    {
        public void Configure(EntityTypeBuilder<LeaveAllocation> builder)
        {
            builder.HasData(
                    new LeaveAllocation
                    {
                        Id = Guid.NewGuid().ToString(),
                        UserId = "b3c91fd5-bac2-4ec9-a049-fa4a9a2014e1",
                        Year = "2022",
                        TotalAmount = 20,
                        UsedAmount = 1
                    }
                );
        }
    }
}
