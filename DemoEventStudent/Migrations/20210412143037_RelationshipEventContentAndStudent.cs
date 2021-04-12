using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoEventStudent.Migrations
{
    public partial class RelationshipEventContentAndStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "EventContents");

            migrationBuilder.AddColumn<string>(
                name: "StudentId",
                table: "EventContents",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EventContents_StudentId",
                table: "EventContents",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventContents_AspNetUsers_StudentId",
                table: "EventContents",
                column: "StudentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventContents_AspNetUsers_StudentId",
                table: "EventContents");

            migrationBuilder.DropIndex(
                name: "IX_EventContents_StudentId",
                table: "EventContents");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "EventContents");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "EventContents",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: false,
                defaultValue: "");
        }
    }
}
