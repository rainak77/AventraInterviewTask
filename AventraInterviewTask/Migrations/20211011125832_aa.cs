using Microsoft.EntityFrameworkCore.Migrations;

namespace AventraInterviewTask.Migrations
{
    public partial class aa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventActionList");

            migrationBuilder.CreateTable(
                name: "EventActionItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventActionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventActionItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventActionItem_EventCategory_EventCategoryId",
                        column: x => x.EventCategoryId,
                        principalTable: "EventCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventActionItem_EventCategoryId",
                table: "EventActionItem",
                column: "EventCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventActionItem");

            migrationBuilder.CreateTable(
                name: "EventActionList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventActionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventActionList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventActionList_EventCategory_EventCategoryId",
                        column: x => x.EventCategoryId,
                        principalTable: "EventCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventActionList_EventCategoryId",
                table: "EventActionList",
                column: "EventCategoryId");
        }
    }
}
