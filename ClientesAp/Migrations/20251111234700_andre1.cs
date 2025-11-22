using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClientesAp.Migrations
{
    /// <inheritdoc />
    public partial class andre1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "Clientes",
                newSchema: "dbo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Clientes",
                schema: "dbo",
                newName: "Clientes");
        }
    }
}
