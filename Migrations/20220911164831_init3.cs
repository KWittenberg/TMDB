using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TMDB.MVC.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductionCountryDbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    iso_3166_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieDetailsDboId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionCountryDbo", x => x.id);
                    table.ForeignKey(
                        name: "FK_ProductionCountryDbo_MovieDetailsDbo_MovieDetailsDboId",
                        column: x => x.MovieDetailsDboId,
                        principalTable: "MovieDetailsDbo",
                        principalColumn: "MovieDetailsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpokenLanguageDbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    english_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    iso_639_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieDetailsDboId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpokenLanguageDbo", x => x.id);
                    table.ForeignKey(
                        name: "FK_SpokenLanguageDbo_MovieDetailsDbo_MovieDetailsDboId",
                        column: x => x.MovieDetailsDboId,
                        principalTable: "MovieDetailsDbo",
                        principalColumn: "MovieDetailsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductionCountryDbo_MovieDetailsDboId",
                table: "ProductionCountryDbo",
                column: "MovieDetailsDboId");

            migrationBuilder.CreateIndex(
                name: "IX_SpokenLanguageDbo_MovieDetailsDboId",
                table: "SpokenLanguageDbo",
                column: "MovieDetailsDboId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductionCountryDbo");

            migrationBuilder.DropTable(
                name: "SpokenLanguageDbo");
        }
    }
}
