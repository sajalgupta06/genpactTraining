using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ourApp9.Migrations
{
    /// <inheritdoc />
    public partial class productadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PPrice = table.Column<int>(type: "int", nullable: false),
                    PMDate = table.Column<int>(type: "int", nullable: false),
                    CId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductInfos_CompanyInfos_CId",
                        column: x => x.CId,
                        principalTable: "CompanyInfos",
                        principalColumn: "CId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProductInfos",
                columns: new[] { "Id", "CId", "PMDate", "PName", "PPrice" },
                values: new object[] { 101, 1, 0, "Samsung", 12000 });

            migrationBuilder.CreateIndex(
                name: "IX_ProductInfos_CId",
                table: "ProductInfos",
                column: "CId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductInfos");
        }
    }
}
