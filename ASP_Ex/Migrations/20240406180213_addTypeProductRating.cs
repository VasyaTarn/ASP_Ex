using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP_Ex.Migrations
{
    /// <inheritdoc />
    public partial class addTypeProductRating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Rating",
                table: "TypeProducts",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "TypeProducts");
        }
    }
}
