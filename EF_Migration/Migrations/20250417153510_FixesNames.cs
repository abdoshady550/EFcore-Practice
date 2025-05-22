using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Migration.Migrations
{
    /// <inheritdoc />
    public partial class FixesNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Courses_courseId",
                table: "Sections");

            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Instractors_instractorId",
                table: "Sections");

            migrationBuilder.RenameColumn(
                name: "instractorId",
                table: "Sections",
                newName: "InstractorId");

            migrationBuilder.RenameColumn(
                name: "courseId",
                table: "Sections",
                newName: "CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Sections_instractorId",
                table: "Sections",
                newName: "IX_Sections_InstractorId");

            migrationBuilder.RenameIndex(
                name: "IX_Sections_courseId",
                table: "Sections",
                newName: "IX_Sections_CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Courses_CourseId",
                table: "Sections",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Instractors_InstractorId",
                table: "Sections",
                column: "InstractorId",
                principalTable: "Instractors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Courses_CourseId",
                table: "Sections");

            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Instractors_InstractorId",
                table: "Sections");

            migrationBuilder.RenameColumn(
                name: "InstractorId",
                table: "Sections",
                newName: "instractorId");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Sections",
                newName: "courseId");

            migrationBuilder.RenameIndex(
                name: "IX_Sections_InstractorId",
                table: "Sections",
                newName: "IX_Sections_instractorId");

            migrationBuilder.RenameIndex(
                name: "IX_Sections_CourseId",
                table: "Sections",
                newName: "IX_Sections_courseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Courses_courseId",
                table: "Sections",
                column: "courseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Instractors_instractorId",
                table: "Sections",
                column: "instractorId",
                principalTable: "Instractors",
                principalColumn: "Id");
        }
    }
}
