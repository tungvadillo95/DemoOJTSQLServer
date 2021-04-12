using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoEventStudent.Migrations
{
    public partial class CreateTableEventContentCapacity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventContentCapacity",
                columns: table => new
                {
                    EventContentId = table.Column<int>(type: "int", nullable: false),
                    CapacityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventContentCapacity", x => new { x.EventContentId, x.CapacityId });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventContentCapacity");
        }
    }
}
