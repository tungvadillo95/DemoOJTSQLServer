using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoEventStudent.Migrations
{
    public partial class RelationshipEventContentAndCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_EventContents_CourseCurrentId",
                table: "EventContents",
                column: "CourseCurrentId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventContents_Courses_CourseCurrentId",
                table: "EventContents",
                column: "CourseCurrentId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventContents_Courses_CourseCurrentId",
                table: "EventContents");

            migrationBuilder.DropIndex(
                name: "IX_EventContents_CourseCurrentId",
                table: "EventContents");
        }
    }
}
