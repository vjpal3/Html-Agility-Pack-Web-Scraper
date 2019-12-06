using Microsoft.EntityFrameworkCore.Migrations;

namespace HAPWebScraper.Migrations
{
    public partial class ChangeColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Company",
                table: "StocksData",
                newName: "Symbol");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Symbol",
                table: "StocksData",
                newName: "Company");
        }
    }
}
