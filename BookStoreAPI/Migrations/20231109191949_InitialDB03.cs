using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialDB03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Publishers_PublisherId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_PublisherId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PublisherId",
                table: "Users");

            migrationBuilder.CreateIndex(
                name: "IX_Users_pub_id",
                table: "Users",
                column: "pub_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Publishers_pub_id",
                table: "Users",
                column: "pub_id",
                principalTable: "Publishers",
                principalColumn: "pub_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Publishers_pub_id",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_pub_id",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "PublisherId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_PublisherId",
                table: "Users",
                column: "PublisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Publishers_PublisherId",
                table: "Users",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "pub_id");
        }
    }
}
