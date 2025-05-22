using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF_Migration.Migrations
{
    /// <inheritdoc />
    public partial class Addofficeentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "officeId",
                table: "Instractors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    officeName = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    officeLocation = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Instractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "officeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Instractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "officeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Instractors",
                keyColumn: "Id",
                keyValue: 3,
                column: "officeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Instractors",
                keyColumn: "Id",
                keyValue: 4,
                column: "officeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Instractors",
                keyColumn: "Id",
                keyValue: 5,
                column: "officeId",
                value: 5);

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "officeLocation", "officeName" },
                values: new object[,]
                {
                    { 1, "building A", "Off_05" },
                    { 2, "building B", "Off_12" },
                    { 3, "Adminstration", "Off_32" },
                    { 4, "IT Department", "Off_44" },
                    { 5, "IT Department", "Off_43" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Instractors_officeId",
                table: "Instractors",
                column: "officeId",
                unique: true,
                filter: "[officeId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Instractors_Offices_officeId",
                table: "Instractors",
                column: "officeId",
                principalTable: "Offices",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instractors_Offices_officeId",
                table: "Instractors");

            migrationBuilder.DropTable(
                name: "Offices");

            migrationBuilder.DropIndex(
                name: "IX_Instractors_officeId",
                table: "Instractors");

            migrationBuilder.DropColumn(
                name: "officeId",
                table: "Instractors");
        }
    }
}
