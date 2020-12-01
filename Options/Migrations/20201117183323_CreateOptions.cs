using Microsoft.EntityFrameworkCore.Migrations;

namespace Options.Migrations
{
    public partial class CreateOptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Symbol = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    StrikePrice = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    StartDate = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ExpiryDate = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    StockPriceAtSale = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    AveragePrice = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Commission = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Profit = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shares",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Symbol = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    CurrentPrice = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    AveragePrice = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Exchange = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Return = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shares", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "Shares");

            migrationBuilder.DropTable(
                name: "Types");
        }
    }
}
