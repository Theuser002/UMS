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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "c91e2715-f6d1-4865-9c91-48210911fbba",
                            ConcurrencyStamp = "e4d96ba0-ffa0-4f5c-8926-9bd0843281f5",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "3d4dc1f7-1b8d-46de-8904-1143669bb93c",
                            ConcurrencyStamp = "b79d8bb0-bafb-4b9c-919a-73be20f64edd",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = "7452daaf-ebe8-49c1-a1ee-59e65ca6f54f",
                            ConcurrencyStamp = "9af6610f-bb57-4110-9a50-5fb4dd7b5bfa",
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "01a43ed8-1651-4bc4-b3f4-97a22307251f",
                            RoleId = "3d4dc1f7-1b8d-46de-8904-1143669bb93c"
                        },
                        new
                        {
                            UserId = "b3c91fd5-bac2-4ec9-a049-fa4a9a2014e1",
                            RoleId = "7452daaf-ebe8-49c1-a1ee-59e65ca6f54f"
                        },
                        new
                        {
                            UserId = "1c3b39f2-60d8-4eb0-8bfc-8c988f97fa7c",
                            RoleId = "c91e2715-f6d1-4865-9c91-48210911fbba"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("UMS.Data.ApiUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "1c3b39f2-60d8-4eb0-8bfc-8c988f97fa7c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "281dc731-3755-4c0e-bc68-9cb073ab39b0",
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "john@example.com",
                            EmailConfirmed = false,
                            FirstName = "John",
                            LastName = "Carter",
                            LockoutEnabled = false,
                            NormalizedEmail = "JOHN@EXAMPLE.COM",
                            NormalizedUserName = "JOHN@EXAMPLE.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEH8lr3ZYXe39cFnHJ9MxFzKYbP8o9DNgCI1WHqz/n/wnAsJpgFl0FDom9srtXesvgg==",
                            PhoneNumber = "0772556545",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "26511aa8-0abf-4723-92ad-a824c3d489be",
                            TwoFactorEnabled = false,
                            UserName = "john@example.com"
                        },
                        new
                        {
                            Id = "b3c91fd5-bac2-4ec9-a049-fa4a9a2014e1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "12463d29-5db7-48fd-a066-7dd069833167",
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "kate@example.com",
                            EmailConfirmed = false,
                            FirstName = "Kate",
                            LastName = "Jones",
                            LockoutEnabled = false,
                            NormalizedEmail = "KATE@EXAMPLE.COM",
                            NormalizedUserName = "KATE@EXAMPLE.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEI8GbzKUXXwaANx3MUmg/Yg87FdLT/TQM7d+fmRxCjPFSsrWFDiQc5wkTnjuZ8Eakw==",
                            PhoneNumber = "0712778595",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9d799e01-3a30-4228-8c0b-475c741cc3c4",
                            TwoFactorEnabled = false,
                            UserName = "kate@example.com"
                        },
                        new
                        {
                            Id = "01a43ed8-1651-4bc4-b3f4-97a22307251f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "43d97f8d-77bd-4080-bf84-e457e3755faa",
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "sam@example.com",
                            EmailConfirmed = false,
                            FirstName = "Sam",
                            LastName = "Peterson",
                            LockoutEnabled = false,
                            NormalizedEmail = "SAM@EXAMPLE.COM",
                            NormalizedUserName = "SAM@EXAMPLE.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEHT4r5Rce0UPAl2QQ2keoLwLuqKOPYqHEsFTzD16i1U8YAli3uEi9Xi04m10w6HXGw==",
                            PhoneNumber = "0751223565",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "723055f0-a39a-44c1-8e18-14e13753e0b8",
                            TwoFactorEnabled = false,
                            UserName = "sam@example.com"
                        });
                });

            modelBuilder.Entity("UMS.Data.LeaveAllocation", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("float");

                    b.Property<double>("UsedAmount")
                        .HasColumnType("float");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Year")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("LeaveAllocations");

                    b.HasData(
                        new
                        {
                            Id = "c630a421-c00d-4ddd-b3e7-6c418292ad44",
                            TotalAmount = 20.0,
                            UsedAmount = 1.0,
                            UserId = "b3c91fd5-bac2-4ec9-a049-fa4a9a2014e1",
                            Year = "2022"
                        });
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

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("LeaveStatusId");

                    b.HasIndex("LeaveTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("LeaveRequests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            End = new DateTime(2022, 2, 4, 13, 48, 39, 777, DateTimeKind.Local).AddTicks(8384),
                            LeaveStatusId = 1,
                            LeaveTypeId = 1,
                            Note = "I am down with fever.",
                            Remarks = "Approved",
                            Start = new DateTime(2022, 2, 3, 13, 48, 39, 776, DateTimeKind.Local).AddTicks(8941),
                            UserId = "b3c91fd5-bac2-4ec9-a049-fa4a9a2014e1"
                        },
                        new
                        {
                            Id = 2,
                            End = new DateTime(2022, 2, 18, 13, 48, 39, 778, DateTimeKind.Local).AddTicks(349),
                            LeaveStatusId = 2,
                            LeaveTypeId = 3,
                            Note = "I am going on a trip to Maldives",
                            Remarks = "Denied",
                            Start = new DateTime(2022, 3, 15, 13, 48, 39, 778, DateTimeKind.Local).AddTicks(337),
                            UserId = "b3c91fd5-bac2-4ec9-a049-fa4a9a2014e1"
                        },
                        new
                        {
                            Id = 3,
                            End = new DateTime(2022, 2, 5, 13, 48, 39, 778, DateTimeKind.Local).AddTicks(354),
                            LeaveStatusId = 3,
                            LeaveTypeId = 2,
                            Note = "Need couple of day off for personal reasons",
                            Remarks = "Approved",
                            Start = new DateTime(2022, 2, 8, 13, 48, 39, 778, DateTimeKind.Local).AddTicks(353),
                            UserId = "b3c91fd5-bac2-4ec9-a049-fa4a9a2014e1"
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("UMS.Data.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("UMS.Data.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UMS.Data.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("UMS.Data.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UMS.Data.LeaveAllocation", b =>
                {
                    b.HasOne("UMS.Data.ApiUser", "ApiUser")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("ApiUser");
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

                    b.HasOne("UMS.Data.ApiUser", "ApiUser")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("ApiUser");

                    b.Navigation("LeaveStatus");

                    b.Navigation("LeaveType");
                });
#pragma warning restore 612, 618
        }
    }
}
