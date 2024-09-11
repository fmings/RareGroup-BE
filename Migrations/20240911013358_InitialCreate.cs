using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace RareGroup_BE.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Label = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Label = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Bio = table.Column<string>(type: "text", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    Uid = table.Column<string>(type: "text", nullable: false),
                    IsStaff = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    PublicationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    Approved = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostTag",
                columns: table => new
                {
                    PostsId = table.Column<int>(type: "integer", nullable: false),
                    TagsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTag", x => new { x.PostsId, x.TagsId });
                    table.ForeignKey(
                        name: "FK_PostTag_Posts_PostsId",
                        column: x => x.PostsId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTag_Tags_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Label" },
                values: new object[,]
                {
                    { 1, "Comedy" },
                    { 2, "Shopping" },
                    { 3, "Music" },
                    { 4, "Sports" },
                    { 5, "Motivational" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Label" },
                values: new object[,]
                {
                    { 1, "#photooftheday" },
                    { 2, "#likeforlike" },
                    { 3, "#food" },
                    { 4, "#music" },
                    { 5, "#amazing" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Active", "Bio", "CreatedOn", "Email", "FirstName", "ImageUrl", "IsStaff", "LastName", "Uid" },
                values: new object[,]
                {
                    { 1, true, "The Island Gyal", new DateTime(2022, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "britnayg@gmail.com", "Britnay", null, false, "Gore", "" },
                    { 2, true, "Team Vibes", new DateTime(2023, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "feliciam@gmail.com", "Felicia", null, false, "Mings", "" },
                    { 3, true, "The Young Manager", new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "fletcherm@gmail.com", "Fletcher", null, false, "Moore", "" },
                    { 4, true, "The Alcohol King", new DateTime(2022, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "colburn.zach7@gmail.com", "Zach", null, false, "Colburn", "" },
                    { 5, true, "Backend Genius", new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "odij@gmail.com", "Odi", null, false, "Joseph", "" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Approved", "CategoryId", "Content", "ImageUrl", "PublicationDate", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, true, 1, "Hello World, how are you today?", "https://static1.squarespace.com/static/5e949a92e17d55230cd1d44f/t/61f35a8548933c4ce4cc0daa/1643338381475/HelloLight_Mac.png?format=1500w", new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hello World", 1 },
                    { 2, false, 2, "Hello Zach, doing well?", "https://upload.wikimedia.org/wikipedia/commons/e/e7/Zach_Galifianakis_2012_%28cropped%29.jpg", new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hello Zach", 2 },
                    { 3, true, 3, "Hello Brit, how's work?", "https://www.rollingstone.com/wp-content/uploads/2022/02/AdeleBritsRedCarpet-1.jpeg", new DateTime(2024, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hello Brit", 3 },
                    { 4, true, 4, "Hello Fletcher, you are turning 21 this year!", "https://www.denofgeek.com/wp-content/uploads/2020/08/chevy-chase-fletch-universal-pictures.jpg?fit=1200%2C680", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hello Fletcher", 4 },
                    { 5, false, 5, "Hello Lola, stop pooping on the bed", "https://i.imgur.com/bS6aYJ5.jpg", new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hello Lola", 5 },
                    { 6, true, 1, "Hello World, how are you today?", "https://static1.squarespace.com/static/5e949a92e17d55230cd1d44f/t/61f35a8548933c4ce4cc0daa/1643338381475/HelloLight_Mac.png?format=1500w", new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hello World 2", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTag_TagsId",
                table: "PostTag",
                column: "TagsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostTag");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
