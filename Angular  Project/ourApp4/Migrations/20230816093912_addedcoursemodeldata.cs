using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ourApp4.Migrations
{
    /// <inheritdoc />
    public partial class addedcoursemodeldata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CFee", "CName", "Status", "Technology" },
                values: new object[] { 1, 12000, "Dot Net", true, "c#" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1);
        }
    }
}
