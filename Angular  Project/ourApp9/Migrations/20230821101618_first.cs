using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ourApp9.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyInfos",
                columns: table => new
                {
                    CId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyInfos", x => x.CId);
                });

            migrationBuilder.InsertData(
                table: "CompanyInfos",
                columns: new[] { "CId", "CName" },
                values: new object[,]
                {
                    { 1, "Samsung" },
                    { 2, "HP" },
                    { 3, "Apple" },
                    { 4, "Dell" },
                    { 5, "Toshiba" },
                    { 6, "Redmi" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyInfos");
        }
    }
}
