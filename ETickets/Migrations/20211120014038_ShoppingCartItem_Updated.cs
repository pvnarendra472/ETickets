using Microsoft.EntityFrameworkCore.Migrations;

namespace ETickets.Migrations
{
    public partial class ShoppingCartItem_Updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Amoun",
                table: "ShoppingCartItems",
                newName: "Amount");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "ShoppingCartItems",
                newName: "Amoun");
        }
    }
}
