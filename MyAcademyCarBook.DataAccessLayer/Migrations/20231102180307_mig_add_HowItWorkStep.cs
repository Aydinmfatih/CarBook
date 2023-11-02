using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAcademyCarBook.DataAccessLayer.Migrations
{
    public partial class mig_add_HowItWorkStep : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HowItWorkSteps",
                columns: table => new
                {
                    HowItWorkStepId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HowItWorkSteps", x => x.HowItWorkStepId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HowItWorkSteps");
        }
    }
}
