using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AzeWHV.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBirthdayColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "生日",
                table: "CustomInfos",
                newName: "Birthday");

            migrationBuilder.RenameColumn(
                name: "NeenToNZ",
                table: "CustomInfos",
                newName: "BeenToNZ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Birthday",
                table: "CustomInfos",
                newName: "生日");

            migrationBuilder.RenameColumn(
                name: "BeenToNZ",
                table: "CustomInfos",
                newName: "NeenToNZ");
        }
    }
}
