using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TMDB.MVC.Migrations
{
    public partial class addCreditsDbo : Migration
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
                name: "CastDbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adult = table.Column<bool>(type: "bit", nullable: false),
                    gender = table.Column<int>(type: "int", nullable: false),
                    known_for_department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    original_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    popularity = table.Column<double>(type: "float", nullable: false),
                    profile_path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cast_id = table.Column<int>(type: "int", nullable: false),
                    character = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    credit_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    order = table.Column<int>(type: "int", nullable: false),
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
                    adult = table.Column<bool>(type: "bit", nullable: false),
                    gender = table.Column<int>(type: "int", nullable: false),
                    known_for_department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    original_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    popularity = table.Column<double>(type: "float", nullable: false),
                    profile_path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    credit_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    job = table.Column<string>(type: "nvarchar(max)", nullable: false),
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

            migrationBuilder.CreateIndex(
                name: "IX_CastDbo_CreditsDboId",
                table: "CastDbo",
                column: "CreditsDboId");

            migrationBuilder.CreateIndex(
                name: "IX_CrewDbo_CreditsDboId",
                table: "CrewDbo",
                column: "CreditsDboId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CastDbo");

            migrationBuilder.DropTable(
                name: "CrewDbo");

            migrationBuilder.DropTable(
                name: "CreditsDbo");
        }
    }
}
