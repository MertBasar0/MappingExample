using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class MigSeven : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentTwo_Courses_CourseId",
                table: "StudentTwo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentTwo",
                table: "StudentTwo");

            migrationBuilder.RenameTable(
                name: "StudentTwo",
                newName: "StudentTwos");

            migrationBuilder.RenameIndex(
                name: "IX_StudentTwo_CourseId",
                table: "StudentTwos",
                newName: "IX_StudentTwos_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentTwos",
                table: "StudentTwos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTwos_Courses_CourseId",
                table: "StudentTwos",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentTwos_Courses_CourseId",
                table: "StudentTwos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentTwos",
                table: "StudentTwos");

            migrationBuilder.RenameTable(
                name: "StudentTwos",
                newName: "StudentTwo");

            migrationBuilder.RenameIndex(
                name: "IX_StudentTwos_CourseId",
                table: "StudentTwo",
                newName: "IX_StudentTwo_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentTwo",
                table: "StudentTwo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTwo_Courses_CourseId",
                table: "StudentTwo",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
