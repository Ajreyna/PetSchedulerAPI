using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PetSchedulerAPI.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    RecordType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobDetails2",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(nullable: false),
                    JobTypeId = table.Column<int>(nullable: false),
                    Duration = table.Column<double>(nullable: false),
                    Distance = table.Column<double>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobDetails2", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobDetails2_JobTypes_JobTypeId",
                        column: x => x.JobTypeId,
                        principalTable: "JobTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobDetails2_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "JobTypes",
                columns: new[] { "Id", "Name", "RecordType" },
                values: new object[] { 1, "Running", 1 });

            migrationBuilder.InsertData(
                table: "JobTypes",
                columns: new[] { "Id", "Name", "RecordType" },
                values: new object[] { 2, "Weights", 0 });

            migrationBuilder.InsertData(
                table: "JobTypes",
                columns: new[] { "Id", "Name", "RecordType" },
                values: new object[] { 3, "Walking", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Test User" });

            migrationBuilder.InsertData(
                table: "JobDetails2",
                columns: new[] { "Id", "JobTypeId", "Date", "Distance", "Duration", "Notes", "UserId" },
                values: new object[] { 1, 1, new DateTime(2019, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0, 30.0, "Hot!!!!", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_JobDetails2_JobTypeId",
                table: "JobDetails2",
                column: "JobTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobDetails2_UserId",
                table: "JobDetails2",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobDetails2");

            migrationBuilder.DropTable(
                name: "JobTypes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
