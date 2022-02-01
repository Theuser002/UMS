using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UMS.Migrations
{
    public partial class AddedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LeaveStatus",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Approved" },
                    { 2, "Denied" },
                    { 3, "Pending" }
                });

            migrationBuilder.InsertData(
                table: "LeaveTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Sick Leave" },
                    { 2, "Personal Leave" },
                    { 3, "Vacation Leave" }
                });

            migrationBuilder.InsertData(
                table: "LeaveRequests",
                columns: new[] { "Id", "End", "LeaveStatusId", "LeaveTypeId", "Note", "Remarks", "Start" },
                values: new object[] { 1, new DateTime(2022, 2, 2, 12, 32, 12, 812, DateTimeKind.Local).AddTicks(503), 1, 1, "I am down with fever.", "Approved", new DateTime(2022, 2, 1, 12, 32, 12, 809, DateTimeKind.Local).AddTicks(9039) });

            migrationBuilder.InsertData(
                table: "LeaveRequests",
                columns: new[] { "Id", "End", "LeaveStatusId", "LeaveTypeId", "Note", "Remarks", "Start" },
                values: new object[] { 3, new DateTime(2022, 2, 3, 12, 32, 12, 812, DateTimeKind.Local).AddTicks(5827), 3, 2, "Need couple of day off for personal reasons", "Approved", new DateTime(2022, 2, 1, 12, 32, 12, 812, DateTimeKind.Local).AddTicks(5826) });

            migrationBuilder.InsertData(
                table: "LeaveRequests",
                columns: new[] { "Id", "End", "LeaveStatusId", "LeaveTypeId", "Note", "Remarks", "Start" },
                values: new object[] { 2, new DateTime(2022, 2, 16, 12, 32, 12, 812, DateTimeKind.Local).AddTicks(5815), 2, 3, "I am going on a trip to Maldives", "Denied", new DateTime(2022, 2, 1, 12, 32, 12, 812, DateTimeKind.Local).AddTicks(5805) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LeaveStatus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LeaveStatus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LeaveStatus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
