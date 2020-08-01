using Microsoft.EntityFrameworkCore.Migrations;

namespace FunApp.WebApI.Migrations
{
    public partial class AddedRetrospectionModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AreaOfImprovement",
                table: "TeamMembers");

            migrationBuilder.DropColumn(
                name: "GoodPoints",
                table: "TeamMembers");

            migrationBuilder.DropColumn(
                name: "HappinessIndex",
                table: "TeamMembers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AreaOfImprovement",
                table: "TeamMembers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GoodPoints",
                table: "TeamMembers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HappinessIndex",
                table: "TeamMembers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
