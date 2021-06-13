using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreCodeFirstSample_SP21_Evening.Migrations
{
    public partial class EFCoreCodeFirstSampleSP21EveningModelsEmployeeContextSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 1L, new DateTime(1992, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "aliraza@gmail.com", "Ali", "Raza", "090078601" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 2L, new DateTime(1992, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "asadullah@gmail.com", "Asad", "Ullah", "090078601" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2L);
        }
    }
}
