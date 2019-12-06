using Microsoft.EntityFrameworkCore.Migrations;

namespace HAPWebScraper.Migrations
{
    public partial class AddColumnCompanyName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "StocksData",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "StocksData");
        }
    }
}
