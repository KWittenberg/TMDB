using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TMDB.MVC.Migrations
{
    public partial class addCreditsDbo3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CreditsDbo_MovieDetailsDbo_MovieDetailsDboId",
                table: "CreditsDbo");

            migrationBuilder.DropIndex(
                name: "IX_CreditsDbo_MovieDetailsDboId",
                table: "CreditsDbo");

            migrationBuilder.DropColumn(
                name: "MovieDetailsDboId",
                table: "CreditsDbo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MovieDetailsDboId",
                table: "CreditsDbo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CreditsDbo_MovieDetailsDboId",
                table: "CreditsDbo",
                column: "MovieDetailsDboId");

            migrationBuilder.AddForeignKey(
                name: "FK_CreditsDbo_MovieDetailsDbo_MovieDetailsDboId",
                table: "CreditsDbo",
                column: "MovieDetailsDboId",
                principalTable: "MovieDetailsDbo",
                principalColumn: "MovieDetailsId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
