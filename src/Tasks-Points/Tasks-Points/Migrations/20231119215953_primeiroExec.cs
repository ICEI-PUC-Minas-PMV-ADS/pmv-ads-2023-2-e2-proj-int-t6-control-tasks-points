using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tasks_Points.Migrations
{
    public partial class primeiroExec : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Coins",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Coins",
                table: "Usuarios");
        }
    }
}
