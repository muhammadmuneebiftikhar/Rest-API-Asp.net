using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreCodeFirstSample_SP21_Evening.Migrations
{
    public partial class EFCoreCodeFirstSampleSP21EveningModelsRemoveEmployeeGender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Employees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
