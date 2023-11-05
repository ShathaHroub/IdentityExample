using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Identitynext2.Migrations
{
    /// <inheritdoc />
    public partial class Mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isApproved",
                table: "Certificates",
                newName: "ApprovalStatus");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ApprovalStatus",
                table: "Certificates",
                newName: "isApproved");
        }
    }
}
