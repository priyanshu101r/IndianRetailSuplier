using Microsoft.EntityFrameworkCore.Migrations;

namespace IndianRetailSuplier.DATA.Migrations
{
    public partial class migratefisrst1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Category",
                newName: "CategoryName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "Category",
                newName: "FirstName");
        }
    }
}
