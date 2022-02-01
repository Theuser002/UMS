using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace UMS.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveStatus> LeaveStatus { get; set; }     
        public DbSet<LeaveRequest> LeaveRequests { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            /*base.OnModelCreating(builder);*/

            builder.Entity<LeaveType>().HasData(
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

            builder.Entity<LeaveStatus>().HasData(
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

            builder.Entity<LeaveRequest>().HasData(
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
