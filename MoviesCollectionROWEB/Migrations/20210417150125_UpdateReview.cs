using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesCollectionROWEB.Migrations
{
    public partial class UpdateReview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Movie_MovieId",
                table: "Reviews");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "Reviews",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Movie_MovieId",
                table: "Reviews",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Movie_MovieId",
                table: "Reviews");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "Reviews",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Movie_MovieId",
                table: "Reviews",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
