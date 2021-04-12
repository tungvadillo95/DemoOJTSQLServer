using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoEventStudent.Migrations
{
    public partial class RelationshipEventAndEventContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_EventContents_EventId",
                table: "EventContents",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventContents_Events_EventId",
                table: "EventContents",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventContents_Events_EventId",
                table: "EventContents");

            migrationBuilder.DropIndex(
                name: "IX_EventContents_EventId",
                table: "EventContents");
        }
    }
}
