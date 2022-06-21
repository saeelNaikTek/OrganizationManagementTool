using Microsoft.EntityFrameworkCore.Migrations;

namespace OrganizationManagementTool.Migrations
{
    public partial class addingFacultyDepartmentMaster : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DepartmentTbl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentTbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FacultyTbl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Mobile = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(maxLength: 1, nullable: false),
                    DeptId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacultyTbl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FacultyTbl_DepartmentTbl_DeptId",
                        column: x => x.DeptId,
                        principalTable: "DepartmentTbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FacultyTbl_DeptId",
                table: "FacultyTbl",
                column: "DeptId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FacultyTbl");

            migrationBuilder.DropTable(
                name: "DepartmentTbl");
        }
    }
}
