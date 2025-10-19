using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RelationShipsBetweenEmployeeAndDepartment.Data.Migrations
{
    /// <inheritdoc />
    public partial class TryToAddWorkRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WorkDepartmentDepartmentId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_WorkDepartmentDepartmentId",
                table: "Employees",
                column: "WorkDepartmentDepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_WorkDepartmentDepartmentId",
                table: "Employees",
                column: "WorkDepartmentDepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_WorkDepartmentDepartmentId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_WorkDepartmentDepartmentId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "WorkDepartmentDepartmentId",
                table: "Employees");
        }
    }
}
