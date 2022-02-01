﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UMS.Data;

namespace UMS.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UMS.Data.LeaveAllocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("TotalAmount")
                        .HasColumnType("float");

                    b.Property<double>("UsedAmount")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("LeaveAllocations");
                });

            modelBuilder.Entity("UMS.Data.LeaveRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.Property<int>("LeaveStatusId")
                        .HasColumnType("int");

                    b.Property<int>("LeaveTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("LeaveStatusId");

                    b.HasIndex("LeaveTypeId");

                    b.ToTable("LeaveRequests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            End = new DateTime(2022, 2, 2, 12, 32, 12, 812, DateTimeKind.Local).AddTicks(503),
                            LeaveStatusId = 1,
                            LeaveTypeId = 1,
                            Note = "I am down with fever.",
                            Remarks = "Approved",
                            Start = new DateTime(2022, 2, 1, 12, 32, 12, 809, DateTimeKind.Local).AddTicks(9039)
                        },
                        new
                        {
                            Id = 2,
                            End = new DateTime(2022, 2, 16, 12, 32, 12, 812, DateTimeKind.Local).AddTicks(5815),
                            LeaveStatusId = 2,
                            LeaveTypeId = 3,
                            Note = "I am going on a trip to Maldives",
                            Remarks = "Denied",
                            Start = new DateTime(2022, 2, 1, 12, 32, 12, 812, DateTimeKind.Local).AddTicks(5805)
                        },
                        new
                        {
                            Id = 3,
                            End = new DateTime(2022, 2, 3, 12, 32, 12, 812, DateTimeKind.Local).AddTicks(5827),
                            LeaveStatusId = 3,
                            LeaveTypeId = 2,
                            Note = "Need couple of day off for personal reasons",
                            Remarks = "Approved",
                            Start = new DateTime(2022, 2, 1, 12, 32, 12, 812, DateTimeKind.Local).AddTicks(5826)
                        });
                });

            modelBuilder.Entity("UMS.Data.LeaveStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LeaveStatus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Approved"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Denied"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Pending"
                        });
                });

            modelBuilder.Entity("UMS.Data.LeaveType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LeaveTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Sick Leave"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Personal Leave"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Vacation Leave"
                        });
                });

            modelBuilder.Entity("UMS.Data.LeaveRequest", b =>
                {
                    b.HasOne("UMS.Data.LeaveStatus", "LeaveStatus")
                        .WithMany()
                        .HasForeignKey("LeaveStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UMS.Data.LeaveType", "LeaveType")
                        .WithMany()
                        .HasForeignKey("LeaveTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LeaveStatus");

                    b.Navigation("LeaveType");
                });
#pragma warning restore 612, 618
        }
    }
}
