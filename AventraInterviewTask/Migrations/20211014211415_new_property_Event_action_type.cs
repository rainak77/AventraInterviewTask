using Microsoft.EntityFrameworkCore.Migrations;

namespace AventraInterviewTask.Migrations
{
    public partial class new_property_Event_action_type : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EventActionType",
                table: "EventActionProperty",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EventActionType",
                table: "EventActionProperty");
        }
    }
}
