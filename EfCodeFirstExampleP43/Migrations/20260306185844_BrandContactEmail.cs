using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCodeFirstExampleP43.Migrations
{
    /// <inheritdoc />
    public partial class BrandContactEmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContactEmail",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactEmail",
                table: "Brands");
        }
    }
}
