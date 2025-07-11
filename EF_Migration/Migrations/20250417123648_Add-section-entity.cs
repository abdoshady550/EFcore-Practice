﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF_Migration.Migrations
{
    /// <inheritdoc />
    public partial class Addsectionentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    sectionName = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    courseId = table.Column<int>(type: "int", nullable: false),
                    instractorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sections_Courses_courseId",
                        column: x => x.courseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sections_Instractors_instractorId",
                        column: x => x.instractorId,
                        principalTable: "Instractors",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "courseId", "instractorId", "sectionName" },
                values: new object[,]
                {
                    { 1, 1, 1, "S_MA1" },
                    { 2, 1, 2, "S_MA2" },
                    { 3, 2, 1, "S_PH1" },
                    { 4, 2, 3, "S_PH2" },
                    { 5, 3, 2, "S_CH1" },
                    { 6, 3, 3, "S_CH2" },
                    { 7, 4, 4, "S_BI1" },
                    { 8, 4, 5, "S_BI2" },
                    { 9, 5, 4, "S_CS1" },
                    { 10, 5, 5, "S_CS2" },
                    { 11, 5, 4, "S_CS3" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sections_courseId",
                table: "Sections",
                column: "courseId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_instractorId",
                table: "Sections",
                column: "instractorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sections");
        }
    }
}
