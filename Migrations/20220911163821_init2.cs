using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TMDB.MVC.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductionCompanyDbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    logo_path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    origin_country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieDetailsDboId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionCompanyDbo", x => x.id);
                    table.ForeignKey(
                        name: "FK_ProductionCompanyDbo_MovieDetailsDbo_MovieDetailsDboId",
                        column: x => x.MovieDetailsDboId,
                        principalTable: "MovieDetailsDbo",
                        principalColumn: "MovieDetailsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductionCompanyDbo_MovieDetailsDboId",
                table: "ProductionCompanyDbo",
                column: "MovieDetailsDboId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductionCompanyDbo");
        }
    }
}
