using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace movie_app.Migrations
{
    /// <inheritdoc />
    public partial class Init17 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NewRate",
                table: "Movie",
                newName: "Sum");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Movie",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Movie");

            migrationBuilder.RenameColumn(
                name: "Sum",
                table: "Movie",
                newName: "NewRate");
        }
    }
}
