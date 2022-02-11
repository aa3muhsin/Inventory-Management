using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory_Management.Migrations
{
    public partial class seedings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AssetTypes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Monitor" });

            migrationBuilder.InsertData(
                table: "AssetTypes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "CPU" });

            migrationBuilder.InsertData(
                table: "AssetTypes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Keyboard" });

            migrationBuilder.InsertData(
                table: "AssetTypes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Mouse" });

            migrationBuilder.InsertData(
                table: "AssetTypes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Printer" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Administration" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Accounts" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Human Resources" });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetNumber", "AssignedDate", "DiscardedDate", "LastReturnedDate", "PurchasedDate", "Status", "TypeId" },
                values: new object[] { 1, "C8619B9", null, null, null, new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetNumber", "AssignedDate", "DiscardedDate", "LastReturnedDate", "PurchasedDate", "Status", "TypeId" },
                values: new object[] { 2, "C8619BA", null, null, null, new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetNumber", "AssignedDate", "DiscardedDate", "LastReturnedDate", "PurchasedDate", "Status", "TypeId" },
                values: new object[] { 3, "C8619BB", null, null, null, new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetNumber", "AssignedDate", "DiscardedDate", "LastReturnedDate", "PurchasedDate", "Status", "TypeId" },
                values: new object[] { 4, "C8619BC", null, null, null, new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), 0, 4 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetNumber", "AssignedDate", "DiscardedDate", "LastReturnedDate", "PurchasedDate", "Status", "TypeId" },
                values: new object[] { 5, "C8619BD", null, null, null, new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), 0, 5 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetNumber", "AssignedDate", "DiscardedDate", "LastReturnedDate", "PurchasedDate", "Status", "TypeId" },
                values: new object[] { 6, "C8619C2", null, null, new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetNumber", "AssignedDate", "DiscardedDate", "LastReturnedDate", "PurchasedDate", "Status", "TypeId" },
                values: new object[] { 7, "C8619C3", null, null, new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetNumber", "AssignedDate", "DiscardedDate", "LastReturnedDate", "PurchasedDate", "Status", "TypeId" },
                values: new object[] { 8, "C8619C4", null, null, new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), 1, 3 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetNumber", "AssignedDate", "DiscardedDate", "LastReturnedDate", "PurchasedDate", "Status", "TypeId" },
                values: new object[] { 9, "C8619C5", null, null, new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), 1, 4 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetNumber", "AssignedDate", "DiscardedDate", "LastReturnedDate", "PurchasedDate", "Status", "TypeId" },
                values: new object[] { 10, "C861A26", null, new DateTime(2021, 1, 20, 14, 15, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetNumber", "AssignedDate", "DiscardedDate", "LastReturnedDate", "PurchasedDate", "Status", "TypeId" },
                values: new object[] { 11, "C861A27", null, new DateTime(2021, 1, 20, 14, 15, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "DepartmentId", "Name", "NID", "StaffNumber" },
                values: new object[] { 1, 1, "Ahmed Mohamed", "A123456", "A001" });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "DepartmentId", "Name", "NID", "StaffNumber" },
                values: new object[] { 2, 1, "Hussain Ali", "A223422", "A002" });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "DepartmentId", "Name", "NID", "StaffNumber" },
                values: new object[] { 3, 2, "Fathimath Moosa Manik", "A323433", "B003" });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "DepartmentId", "Name", "NID", "StaffNumber" },
                values: new object[] { 4, 2, "Ibrahim Hussain", "A423444", "A017" });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "DepartmentId", "Name", "NID", "StaffNumber" },
                values: new object[] { 5, 3, "Aishath Mariyam", "A523455", "EE01" });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "DepartmentId", "Name", "NID", "StaffNumber" },
                values: new object[] { 6, 3, "Hassan Ali Ibrahim", "A623466", "AE001" });

            migrationBuilder.InsertData(
                table: "AssetsHistory",
                columns: new[] { "Id", "AssetId", "AssignedDate", "StaffId", "UnAssignedDate" },
                values: new object[] { 1, 6, new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), 2, null });

            migrationBuilder.InsertData(
                table: "AssetsHistory",
                columns: new[] { "Id", "AssetId", "AssignedDate", "StaffId", "UnAssignedDate" },
                values: new object[] { 2, 7, new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), 2, null });

            migrationBuilder.InsertData(
                table: "AssetsHistory",
                columns: new[] { "Id", "AssetId", "AssignedDate", "StaffId", "UnAssignedDate" },
                values: new object[] { 3, 8, new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), 2, null });

            migrationBuilder.InsertData(
                table: "AssetsHistory",
                columns: new[] { "Id", "AssetId", "AssignedDate", "StaffId", "UnAssignedDate" },
                values: new object[] { 4, 9, new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), 2, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AssetsHistory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AssetsHistory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AssetsHistory",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AssetsHistory",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AssetTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AssetTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AssetTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AssetTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AssetTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
