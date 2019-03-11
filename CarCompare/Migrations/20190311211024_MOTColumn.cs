using Microsoft.EntityFrameworkCore.Migrations;

namespace CarCompare.Migrations
{
    public partial class MOTColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MotExpiry",
                table: "Car",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MotExpiry",
                table: "Car");
        }
    }
}
