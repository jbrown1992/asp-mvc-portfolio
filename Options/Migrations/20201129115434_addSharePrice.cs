using Microsoft.EntityFrameworkCore.Migrations;

namespace Options.Migrations
{
    public partial class addSharePrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SharePrice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Symbol = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    LastTimeCheck = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CurrentPrice = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SharePrice", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SharePrice");
        }
    }
}
