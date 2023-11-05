using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Identitynext2.Migrations
{
    /// <inheritdoc />
    public partial class Mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApprovalStatus",
                table: "Certificates");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Certificates",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Certificates");

            migrationBuilder.AddColumn<bool>(
                name: "ApprovalStatus",
                table: "Certificates",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
