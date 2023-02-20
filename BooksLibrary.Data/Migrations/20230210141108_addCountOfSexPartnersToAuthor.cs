using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BooksLibrary.Data.Migrations
{
    /// <inheritdoc />
    public partial class addCountOfSexPartnersToAuthor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountOfSexPartners",
                table: "Authors",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountOfSexPartners",
                table: "Authors");
        }
    }
}
