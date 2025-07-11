﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF_Migration.Migrations
{
    /// <inheritdoc />
    public partial class AdjustRelationSectionSchadule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SectionScheduleS");

            migrationBuilder.AddColumn<int>(
                name: "ScheduleId",
                table: "Sections",
                type: "int",
                nullable: false,
                defaultValue: 0);


            migrationBuilder.AddColumn<TimeSpan>(
                name: "StartTime",
                table: "Sections",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "EndTime",
                table: "Sections",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));


            migrationBuilder.AddColumn<int>(
                name: "SectionId",
                table: "Schedule",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Schedule",
                keyColumn: "Id",
                keyValue: 1,
                column: "SectionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Schedule",
                keyColumn: "Id",
                keyValue: 2,
                column: "SectionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Schedule",
                keyColumn: "Id",
                keyValue: 3,
                column: "SectionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Schedule",
                keyColumn: "Id",
                keyValue: 4,
                column: "SectionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Schedule",
                keyColumn: "Id",
                keyValue: 5,
                column: "SectionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndTime", "ScheduleId", "StartTime" },
                values: new object[] { new TimeSpan(0, 10, 0, 0, 0), 1, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndTime", "ScheduleId", "StartTime" },
                values: new object[] { new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndTime", "ScheduleId", "StartTime" },
                values: new object[] { new TimeSpan(0, 15, 0, 0, 0), 4, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndTime", "ScheduleId", "StartTime" },
                values: new object[] { new TimeSpan(0, 12, 0, 0, 0), 1, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndTime", "ScheduleId", "StartTime" },
                values: new object[] { new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndTime", "ScheduleId", "StartTime" },
                values: new object[] { new TimeSpan(0, 10, 0, 0, 0), 2, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndTime", "ScheduleId", "StartTime" },
                values: new object[] { new TimeSpan(0, 14, 0, 0, 0), 3, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndTime", "ScheduleId", "StartTime" },
                values: new object[] { new TimeSpan(0, 14, 0, 0, 0), 4, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndTime", "ScheduleId", "StartTime" },
                values: new object[] { new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndTime", "ScheduleId", "StartTime" },
                values: new object[] { new TimeSpan(0, 15, 0, 0, 0), 3, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndTime", "ScheduleId", "StartTime" },
                values: new object[] { new TimeSpan(0, 11, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.CreateIndex(
                name: "IX_Sections_ScheduleId",
                table: "Sections",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_SectionId",
                table: "Schedule",
                column: "SectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Sections_SectionId",
                table: "Schedule",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Schedule_ScheduleId",
                table: "Sections",
                column: "ScheduleId",
                principalTable: "Schedule",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Sections_SectionId",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Schedule_ScheduleId",
                table: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_Sections_ScheduleId",
                table: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_Schedule_SectionId",
                table: "Schedule");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "ScheduleId",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "SectionId",
                table: "Schedule");

            migrationBuilder.CreateTable(
                name: "SectionScheduleS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    ScheduleId = table.Column<int>(type: "int", nullable: false),
                    SectionId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionScheduleS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SectionScheduleS_Schedule_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SectionScheduleS_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SectionScheduleS",
                columns: new[] { "Id", "EndTime", "ScheduleId", "SectionId", "StartTime" },
                values: new object[,]
                {
                    { 1, new TimeSpan(0, 10, 0, 0, 0), 1, 1, new TimeSpan(0, 8, 0, 0, 0) },
                    { 2, new TimeSpan(0, 18, 0, 0, 0), 3, 2, new TimeSpan(0, 14, 0, 0, 0) },
                    { 3, new TimeSpan(0, 15, 0, 0, 0), 4, 3, new TimeSpan(0, 10, 0, 0, 0) },
                    { 4, new TimeSpan(0, 12, 0, 0, 0), 1, 4, new TimeSpan(0, 10, 0, 0, 0) },
                    { 5, new TimeSpan(0, 18, 0, 0, 0), 1, 5, new TimeSpan(0, 16, 0, 0, 0) },
                    { 6, new TimeSpan(0, 10, 0, 0, 0), 2, 6, new TimeSpan(0, 8, 0, 0, 0) },
                    { 7, new TimeSpan(0, 14, 0, 0, 0), 3, 7, new TimeSpan(0, 11, 0, 0, 0) },
                    { 8, new TimeSpan(0, 14, 0, 0, 0), 4, 8, new TimeSpan(0, 10, 0, 0, 0) },
                    { 9, new TimeSpan(0, 18, 0, 0, 0), 4, 9, new TimeSpan(0, 16, 0, 0, 0) },
                    { 10, new TimeSpan(0, 15, 0, 0, 0), 3, 10, new TimeSpan(0, 12, 0, 0, 0) },
                    { 11, new TimeSpan(0, 11, 0, 0, 0), 5, 11, new TimeSpan(0, 9, 0, 0, 0) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SectionScheduleS_ScheduleId",
                table: "SectionScheduleS",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionScheduleS_SectionId",
                table: "SectionScheduleS",
                column: "SectionId");
        }
    }
}
