using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PresseMots.Migrations
{
    /// <inheritdoc />
    public partial class storytag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoryTag_Stories_StoriesId",
                table: "StoryTag");

            migrationBuilder.DropForeignKey(
                name: "FK_StoryTag_Tag_TagsId",
                table: "StoryTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StoryTag",
                table: "StoryTag");

            migrationBuilder.RenameColumn(
                name: "TagsId",
                table: "StoryTag",
                newName: "TagId");

            migrationBuilder.RenameColumn(
                name: "StoriesId",
                table: "StoryTag",
                newName: "StoryId");

            migrationBuilder.RenameIndex(
                name: "IX_StoryTag_TagsId",
                table: "StoryTag",
                newName: "IX_StoryTag_TagId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "StoryTag",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoryTag",
                table: "StoryTag",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_StoryTag_StoryId",
                table: "StoryTag",
                column: "StoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_StoryTag_Stories_StoryId",
                table: "StoryTag",
                column: "StoryId",
                principalTable: "Stories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StoryTag_Tag_TagId",
                table: "StoryTag",
                column: "TagId",
                principalTable: "Tag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoryTag_Stories_StoryId",
                table: "StoryTag");

            migrationBuilder.DropForeignKey(
                name: "FK_StoryTag_Tag_TagId",
                table: "StoryTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StoryTag",
                table: "StoryTag");

            migrationBuilder.DropIndex(
                name: "IX_StoryTag_StoryId",
                table: "StoryTag");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "StoryTag");

            migrationBuilder.RenameColumn(
                name: "TagId",
                table: "StoryTag",
                newName: "TagsId");

            migrationBuilder.RenameColumn(
                name: "StoryId",
                table: "StoryTag",
                newName: "StoriesId");

            migrationBuilder.RenameIndex(
                name: "IX_StoryTag_TagId",
                table: "StoryTag",
                newName: "IX_StoryTag_TagsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoryTag",
                table: "StoryTag",
                columns: new[] { "StoriesId", "TagsId" });

            migrationBuilder.AddForeignKey(
                name: "FK_StoryTag_Stories_StoriesId",
                table: "StoryTag",
                column: "StoriesId",
                principalTable: "Stories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StoryTag_Tag_TagsId",
                table: "StoryTag",
                column: "TagsId",
                principalTable: "Tag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
