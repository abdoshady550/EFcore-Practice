using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Migration.Migrations
{
    /// <inheritdoc />
    public partial class Fix1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "sectionName",
                table: "Sections",
                newName: "SectionName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SectionName",
                table: "Sections",
                newName: "sectionName");
        }
    }
}
