using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoEventStudent.Migrations
{
    public partial class RelationshipRoleCourseAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TeacherId",
                table: "RoleCourses",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StudentId",
                table: "RoleCourses",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DoctorId",
                table: "RoleCourses",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoleCourses_DoctorId",
                table: "RoleCourses",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleCourses_StudentId",
                table: "RoleCourses",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleCourses_TeacherId",
                table: "RoleCourses",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleCourses_AspNetUsers_DoctorId",
                table: "RoleCourses",
                column: "DoctorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleCourses_AspNetUsers_StudentId",
                table: "RoleCourses",
                column: "StudentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleCourses_AspNetUsers_TeacherId",
                table: "RoleCourses",
                column: "TeacherId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoleCourses_AspNetUsers_DoctorId",
                table: "RoleCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleCourses_AspNetUsers_StudentId",
                table: "RoleCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleCourses_AspNetUsers_TeacherId",
                table: "RoleCourses");

            migrationBuilder.DropIndex(
                name: "IX_RoleCourses_DoctorId",
                table: "RoleCourses");

            migrationBuilder.DropIndex(
                name: "IX_RoleCourses_StudentId",
                table: "RoleCourses");

            migrationBuilder.DropIndex(
                name: "IX_RoleCourses_TeacherId",
                table: "RoleCourses");

            migrationBuilder.AlterColumn<string>(
                name: "TeacherId",
                table: "RoleCourses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StudentId",
                table: "RoleCourses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DoctorId",
                table: "RoleCourses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }
    }
}
