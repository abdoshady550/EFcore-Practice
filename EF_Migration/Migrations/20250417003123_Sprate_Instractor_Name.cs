using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Migration.Migrations
{
    /// <inheritdoc />
    public partial class Sprate_Instractor_Name : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Instractors");

            migrationBuilder.AddColumn<string>(
                name: "Fname",
                table: "Instractors",
                type: "VARCHAR(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Lname",
                table: "Instractors",
                type: "VARCHAR(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Instractors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fname", "Lname" },
                values: new object[] { "Ahmed", "Khalid" });

            migrationBuilder.UpdateData(
                table: "Instractors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Fname", "Lname" },
                values: new object[] { "Yasmeen", "Sobhy" });

            migrationBuilder.UpdateData(
                table: "Instractors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Fname", "Lname" },
                values: new object[] { "Khalid", "Hossam" });

            migrationBuilder.UpdateData(
                table: "Instractors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Fname", "Lname" },
                values: new object[] { "Nadia", "Hessen" });

            migrationBuilder.UpdateData(
                table: "Instractors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Fname", "Lname" },
                values: new object[] { "Ahmed", "Tarek" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fname",
                table: "Instractors");

            migrationBuilder.DropColumn(
                name: "Lname",
                table: "Instractors");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Instractors",
                type: "VARCHAR(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Instractors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Ahmed");

            migrationBuilder.UpdateData(
                table: "Instractors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Yasmeen");

            migrationBuilder.UpdateData(
                table: "Instractors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Khalid");

            migrationBuilder.UpdateData(
                table: "Instractors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Nadia");

            migrationBuilder.UpdateData(
                table: "Instractors",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Ahmed");
        }
    }
}
