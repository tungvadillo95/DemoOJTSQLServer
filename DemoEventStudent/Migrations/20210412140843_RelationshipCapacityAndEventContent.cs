using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoEventStudent.Migrations
{
    public partial class RelationshipCapacityAndEventContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_EventContentCapacity_CapacityId",
                table: "EventContentCapacity",
                column: "CapacityId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventContentCapacity_Capacities_CapacityId",
                table: "EventContentCapacity",
                column: "CapacityId",
                principalTable: "Capacities",
                principalColumn: "CapacityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EventContentCapacity_EventContents_EventContentId",
                table: "EventContentCapacity",
                column: "EventContentId",
                principalTable: "EventContents",
                principalColumn: "EventContentId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventContentCapacity_Capacities_CapacityId",
                table: "EventContentCapacity");

            migrationBuilder.DropForeignKey(
                name: "FK_EventContentCapacity_EventContents_EventContentId",
                table: "EventContentCapacity");

            migrationBuilder.DropIndex(
                name: "IX_EventContentCapacity_CapacityId",
                table: "EventContentCapacity");
        }
    }
}
