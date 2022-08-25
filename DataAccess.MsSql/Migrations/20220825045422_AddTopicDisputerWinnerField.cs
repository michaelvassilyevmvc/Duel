using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.MsSql.Migrations
{
    public partial class AddTopicDisputerWinnerField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsWinner",
                table: "TopicDisputers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsWinner",
                table: "TopicDisputers");
        }
    }
}
