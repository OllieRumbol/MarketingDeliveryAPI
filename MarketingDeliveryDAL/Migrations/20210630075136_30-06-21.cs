using Microsoft.EntityFrameworkCore.Migrations;

namespace MarketingDeliveryDAL.Migrations
{
    public partial class _300621 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Modal",
                table: "Car",
                newName: "Model");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Model",
                table: "Car",
                newName: "Modal");
        }
    }
}
