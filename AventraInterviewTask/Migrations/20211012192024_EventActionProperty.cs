using Microsoft.EntityFrameworkCore.Migrations;

namespace AventraInterviewTask.Migrations
{
    public partial class EventActionProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventActionProperty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventCategoryId = table.Column<int>(type: "int", nullable: false),
                    EventActionItemId = table.Column<int>(type: "int", nullable: false),
                    SupportEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupportEmailCC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailTemplate = table.Column<int>(type: "int", nullable: false),
                    Validate = table.Column<bool>(type: "bit", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HttpMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpectedHttpStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxRecordsPerFile = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventActionProperty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventActionProperty_EventActionItem_EventActionItemId",
                        column: x => x.EventActionItemId,
                        principalTable: "EventActionItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_EventActionProperty_EventCategory_EventCategoryId",
                        column: x => x.EventCategoryId,
                        principalTable: "EventCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventActionProperty_EventActionItemId",
                table: "EventActionProperty",
                column: "EventActionItemId");

            migrationBuilder.CreateIndex(
                name: "IX_EventActionProperty_EventCategoryId",
                table: "EventActionProperty",
                column: "EventCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventActionProperty");
        }
    }
}
