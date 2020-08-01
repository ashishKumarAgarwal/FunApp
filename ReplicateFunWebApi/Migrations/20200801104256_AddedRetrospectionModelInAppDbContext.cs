using Microsoft.EntityFrameworkCore.Migrations;

namespace FunApp.WebApI.Migrations
{
    public partial class AddedRetrospectionModelInAppDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TeamMembers",
                table: "TeamMembers");

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TeamMembers");

            migrationBuilder.AddColumn<int>(
                name: "TeamMemberId",
                table: "TeamMembers",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeamMembers",
                table: "TeamMembers",
                column: "TeamMemberId");

            migrationBuilder.CreateTable(
                name: "Retrospection",
                columns: table => new
                {
                    RetrospectionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(nullable: false),
                    Wentwell = table.Column<string>(nullable: true),
                    AreaOfImprovement = table.Column<string>(nullable: true),
                    HappinessIndex = table.Column<string>(nullable: true),
                    TeamMemberId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Retrospection", x => x.RetrospectionId);
                    table.ForeignKey(
                        name: "FK_Retrospection_TeamMembers_TeamMemberId",
                        column: x => x.TeamMemberId,
                        principalTable: "TeamMembers",
                        principalColumn: "TeamMemberId",
                        onDelete: ReferentialAction.Cascade);
                });

           
            migrationBuilder.CreateIndex(
                name: "IX_Retrospection_TeamMemberId",
                table: "Retrospection",
                column: "TeamMemberId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Retrospection");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeamMembers",
                table: "TeamMembers");

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "TeamMemberId",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "TeamMemberId",
                table: "TeamMembers");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TeamMembers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeamMembers",
                table: "TeamMembers",
                column: "Id");

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "Id", "Birthday", "Designation", "Experience", "FacebookLink", "FunName", "Hobbies", "InstagramLink", "InterestedTechnologies", "JoinedOn", "LinkedInLink", "Name", "PrimarySkills", "SecondarySkills", "imgUrl" },
                values: new object[] { 1, null, null, null, null, null, null, null, null, null, null, "Ashish", null, null, null });
        }
    }
}
