using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TMDB.MVC.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CreditsDbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditsDbo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MovieDetailsDbo",
                columns: table => new
                {
                    MovieDetailsDboId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adult = table.Column<bool>(type: "bit", nullable: true),
                    backdrop_path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    budget = table.Column<int>(type: "int", nullable: false),
                    homepage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id = table.Column<int>(type: "int", nullable: false),
                    imdb_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    original_language = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    original_title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    overview = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    popularity = table.Column<double>(type: "float", nullable: true),
                    poster_path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    release_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    revenue = table.Column<int>(type: "int", nullable: true),
                    runtime = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tagline = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    video = table.Column<bool>(type: "bit", nullable: true),
                    vote_average = table.Column<double>(type: "float", nullable: true),
                    vote_count = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieDetailsDbo", x => x.MovieDetailsDboId);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MoviesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adult = table.Column<bool>(type: "bit", nullable: false),
                    backdrop_path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id = table.Column<int>(type: "int", nullable: false),
                    original_language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    original_title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    overview = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    popularity = table.Column<double>(type: "float", nullable: false),
                    poster_path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    release_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    video = table.Column<bool>(type: "bit", nullable: false),
                    vote_average = table.Column<double>(type: "float", nullable: false),
                    vote_count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MoviesId);
                });

            migrationBuilder.CreateTable(
                name: "CastDbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adult = table.Column<bool>(type: "bit", nullable: true),
                    gender = table.Column<int>(type: "int", nullable: true),
                    known_for_department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    original_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    popularity = table.Column<double>(type: "float", nullable: true),
                    profile_path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cast_id = table.Column<int>(type: "int", nullable: true),
                    character = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    credit_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    order = table.Column<int>(type: "int", nullable: true),
                    CreditsDboId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CastDbo", x => x.id);
                    table.ForeignKey(
                        name: "FK_CastDbo_CreditsDbo_CreditsDboId",
                        column: x => x.CreditsDboId,
                        principalTable: "CreditsDbo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CrewDbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adult = table.Column<bool>(type: "bit", nullable: true),
                    gender = table.Column<int>(type: "int", nullable: true),
                    known_for_department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    original_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    popularity = table.Column<double>(type: "float", nullable: true),
                    profile_path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    credit_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    job = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditsDboId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrewDbo", x => x.id);
                    table.ForeignKey(
                        name: "FK_CrewDbo_CreditsDbo_CreditsDboId",
                        column: x => x.CreditsDboId,
                        principalTable: "CreditsDbo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenreDbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieDetailsDboId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreDbo", x => x.id);
                    table.ForeignKey(
                        name: "FK_GenreDbo_MovieDetailsDbo_MovieDetailsDboId",
                        column: x => x.MovieDetailsDboId,
                        principalTable: "MovieDetailsDbo",
                        principalColumn: "MovieDetailsDboId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                        principalColumn: "MovieDetailsDboId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                        principalColumn: "MovieDetailsDboId",
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
                        principalColumn: "MovieDetailsDboId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CastDbo_CreditsDboId",
                table: "CastDbo",
                column: "CreditsDboId");

            migrationBuilder.CreateIndex(
                name: "IX_CrewDbo_CreditsDboId",
                table: "CrewDbo",
                column: "CreditsDboId");

            migrationBuilder.CreateIndex(
                name: "IX_GenreDbo_MovieDetailsDboId",
                table: "GenreDbo",
                column: "MovieDetailsDboId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionCompanyDbo_MovieDetailsDboId",
                table: "ProductionCompanyDbo",
                column: "MovieDetailsDboId");

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
                name: "CastDbo");

            migrationBuilder.DropTable(
                name: "CrewDbo");

            migrationBuilder.DropTable(
                name: "GenreDbo");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "ProductionCompanyDbo");

            migrationBuilder.DropTable(
                name: "ProductionCountryDbo");

            migrationBuilder.DropTable(
                name: "SpokenLanguageDbo");

            migrationBuilder.DropTable(
                name: "CreditsDbo");

            migrationBuilder.DropTable(
                name: "MovieDetailsDbo");
        }
    }
}
