using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Migration.Migrations
{
    /// <inheritdoc />
    public partial class Fix3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Courses_CourseId",
                table: "Sections");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Sections",
                newName: "Courseld");

            migrationBuilder.RenameIndex(
                name: "IX_Sections_CourseId",
                table: "Sections",
                newName: "IX_Sections_Courseld");

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Courses",
                table: "Sections",
                column: "Courseld",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Courses",
                table: "Sections");

            migrationBuilder.RenameColumn(
                name: "Courseld",
                table: "Sections",
                newName: "CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Sections_Courseld",
                table: "Sections",
                newName: "IX_Sections_CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Courses_CourseId",
                table: "Sections",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");
        }
    }
}
