using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using UMS.Data;

namespace UMS.Configurations.Entities
{
    public class LeaveRequestConfiguration : IEntityTypeConfiguration<LeaveRequest>
    {
        public void Configure(EntityTypeBuilder<LeaveRequest> builder)
        {
            builder.HasData(
                    new LeaveRequest
                    {
                        Id = 1,
                        Start = DateTime.Now,
                        End = DateTime.Now.AddDays(1),
                        Note = "I am down with fever.",
                        Remarks = "Approved",
                        LeaveTypeId = 1,
                        LeaveStatusId = 1
                    },
                    new LeaveRequest
                    {
                        Id = 2,
                        Start = DateTime.Now,
                        End = DateTime.Now.AddDays(15),
                        Note = "I am going on a trip to Maldives",
                        Remarks = "Denied",
                        LeaveTypeId = 3,
                        LeaveStatusId = 2
                    },
                    new LeaveRequest
                    {
                        Id = 3,
                        Start = DateTime.Now,
                        End = DateTime.Now.AddDays(2),
                        Note = "Need couple of day off for personal reasons",
                        Remarks = "Approved",
                        LeaveTypeId = 2,
                        LeaveStatusId = 3
                    }
                );
        }
    }
}
