using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPages.Migrations
{
    public partial class NewDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LikedPostsList_Users_UserId",
                table: "LikedPostsList");

            migrationBuilder.DropForeignKey(
                name: "FK_LikedPostsListPosts_LikedPostsList_LikedPostsListId",
                table: "LikedPostsListPosts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LikedPostsList",
                table: "LikedPostsList");

            migrationBuilder.RenameTable(
                name: "LikedPostsList",
                newName: "LikedPostsLists");

            migrationBuilder.RenameIndex(
                name: "IX_LikedPostsList_UserId",
                table: "LikedPostsLists",
                newName: "IX_LikedPostsLists_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LikedPostsLists",
                table: "LikedPostsLists",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LikedPostsListPosts_LikedPostsLists_LikedPostsListId",
                table: "LikedPostsListPosts",
                column: "LikedPostsListId",
                principalTable: "LikedPostsLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LikedPostsLists_Users_UserId",
                table: "LikedPostsLists",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LikedPostsListPosts_LikedPostsLists_LikedPostsListId",
                table: "LikedPostsListPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_LikedPostsLists_Users_UserId",
                table: "LikedPostsLists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LikedPostsLists",
                table: "LikedPostsLists");

            migrationBuilder.RenameTable(
                name: "LikedPostsLists",
                newName: "LikedPostsList");

            migrationBuilder.RenameIndex(
                name: "IX_LikedPostsLists_UserId",
                table: "LikedPostsList",
                newName: "IX_LikedPostsList_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LikedPostsList",
                table: "LikedPostsList",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LikedPostsList_Users_UserId",
                table: "LikedPostsList",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LikedPostsListPosts_LikedPostsList_LikedPostsListId",
                table: "LikedPostsListPosts",
                column: "LikedPostsListId",
                principalTable: "LikedPostsList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
