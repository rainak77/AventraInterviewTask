using Microsoft.EntityFrameworkCore.Migrations;

namespace AventraInterviewTask.Migrations
{
    public partial class newpropertEventtype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EventType",
                table: "EventActionProperty",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EventType",
                table: "EventActionProperty");
        }
    }
}
