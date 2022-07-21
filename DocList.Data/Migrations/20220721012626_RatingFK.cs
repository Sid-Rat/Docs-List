using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DocList.Data.Migrations
{
    public partial class RatingFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Ratings_JobTypeId",
                table: "Ratings",
                column: "JobTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_JobTypes_JobTypeId",
                table: "Ratings",
                column: "JobTypeId",
                principalTable: "JobTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_JobTypes_JobTypeId",
                table: "Ratings");

            migrationBuilder.DropIndex(
                name: "IX_Ratings_JobTypeId",
                table: "Ratings");
        }
    }
}
