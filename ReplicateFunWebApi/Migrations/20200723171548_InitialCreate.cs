using Microsoft.EntityFrameworkCore.Migrations;

namespace FunApp.WebApI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Designation = table.Column<string>(nullable: true),
                    FunName = table.Column<string>(nullable: true),
                    PrimarySkills = table.Column<string>(nullable: true),
                    SecondarySkills = table.Column<string>(nullable: true),
                    Experience = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "Id", "Designation", "Experience", "FunName", "Name", "PrimarySkills", "SecondarySkills" },
                values: new object[] { 1, null, 0f, null, "Ashish", null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeamMembers");
        }
    }
}
