using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UMS.Migrations
{
    public partial class AddedUserRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c91e2715-f6d1-4865-9c91-48210911fbba", "1fda5c48-edf0-4b35-b020-55885a9aeda6", "Administrator", "ADMINISTRATOR" },
                    { "3d4dc1f7-1b8d-46de-8904-1143669bb93c", "27152696-d595-4c16-af92-45b11abf432c", "Manager", "MANAGER" },
                    { "7452daaf-ebe8-49c1-a1ee-59e65ca6f54f", "2f6232ad-cd34-453b-a11b-ef72e8e4f6ac", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 2, 3, 11, 23, 20, 597, DateTimeKind.Local).AddTicks(2861), new DateTime(2022, 2, 2, 11, 23, 20, 591, DateTimeKind.Local).AddTicks(2418) });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 2, 17, 11, 23, 20, 597, DateTimeKind.Local).AddTicks(4716), new DateTime(2022, 2, 2, 11, 23, 20, 597, DateTimeKind.Local).AddTicks(4708) });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 2, 4, 11, 23, 20, 597, DateTimeKind.Local).AddTicks(4726), new DateTime(2022, 2, 2, 11, 23, 20, 597, DateTimeKind.Local).AddTicks(4725) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d4dc1f7-1b8d-46de-8904-1143669bb93c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7452daaf-ebe8-49c1-a1ee-59e65ca6f54f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c91e2715-f6d1-4865-9c91-48210911fbba");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 2, 2, 19, 13, 57, 944, DateTimeKind.Local).AddTicks(2264), new DateTime(2022, 2, 1, 19, 13, 57, 943, DateTimeKind.Local).AddTicks(2825) });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 2, 16, 19, 13, 57, 944, DateTimeKind.Local).AddTicks(4987), new DateTime(2022, 2, 1, 19, 13, 57, 944, DateTimeKind.Local).AddTicks(4975) });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2022, 2, 3, 19, 13, 57, 944, DateTimeKind.Local).AddTicks(5005), new DateTime(2022, 2, 1, 19, 13, 57, 944, DateTimeKind.Local).AddTicks(5004) });
        }
    }
}
