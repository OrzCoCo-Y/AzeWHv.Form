using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AzeWHV.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomInfos",
                columns: table => new
                {
                    CustomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FamilyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GivenName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Passport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassportExpireDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    生日 = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdStart = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    AddressCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressSuburb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressStreet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NeenToNZ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NzVisitTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomInfos", x => x.CustomId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomInfos");
        }
    }
}
