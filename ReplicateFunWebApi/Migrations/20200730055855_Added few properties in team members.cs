using Microsoft.EntityFrameworkCore.Migrations;

namespace FunApp.WebApI.Migrations
{
    public partial class Addedfewpropertiesinteammembers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Birthday",
                table: "TeamMembers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HappinessIndex",
                table: "TeamMembers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hobbies",
                table: "TeamMembers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InterestedTechnologies",
                table: "TeamMembers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JoinedOn",
                table: "TeamMembers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "TeamMembers");

            migrationBuilder.DropColumn(
                name: "HappinessIndex",
                table: "TeamMembers");

            migrationBuilder.DropColumn(
                name: "Hobbies",
                table: "TeamMembers");

            migrationBuilder.DropColumn(
                name: "InterestedTechnologies",
                table: "TeamMembers");

            migrationBuilder.DropColumn(
                name: "JoinedOn",
                table: "TeamMembers");
        }
    }
}
