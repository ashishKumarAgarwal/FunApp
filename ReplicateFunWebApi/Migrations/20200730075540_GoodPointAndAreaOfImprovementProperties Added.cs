using Microsoft.EntityFrameworkCore.Migrations;

namespace FunApp.WebApI.Migrations
{
    public partial class GoodPointAndAreaOfImprovementPropertiesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AreaOfImprovement",
                table: "TeamMembers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GoodPoints",
                table: "TeamMembers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AreaOfImprovement",
                table: "TeamMembers");

            migrationBuilder.DropColumn(
                name: "GoodPoints",
                table: "TeamMembers");
        }
    }
}
