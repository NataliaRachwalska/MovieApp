using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace movie_app.Migrations
{
    /// <inheritdoc />
    public partial class Init7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NewRate",
                table: "Movie");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "NewRate",
                table: "Movie",
                type: "real",
                nullable: true);
        }
    }
}
