using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoEventStudent.Migrations
{
    public partial class RelationshipRoleCourseAndCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_RoleCourses_CourseCurrentId",
                table: "RoleCourses",
                column: "CourseCurrentId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleCourses_Courses_CourseCurrentId",
                table: "RoleCourses",
                column: "CourseCurrentId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoleCourses_Courses_CourseCurrentId",
                table: "RoleCourses");

            migrationBuilder.DropIndex(
                name: "IX_RoleCourses_CourseCurrentId",
                table: "RoleCourses");
        }
    }
}
