using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acme.BookStoreMVC.Migrations
{
    /// <inheritdoc />
    public partial class AddedBookTranslation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppBookTranslations",
                columns: table => new
                {
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppBookTranslations", x => new { x.BookId, x.Language });
                    table.ForeignKey(
                        name: "FK_AppBookTranslations_AppBooks_BookId",
                        column: x => x.BookId,
                        principalTable: "AppBooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppBooks_AuthorId",
                table: "AppBooks",
                column: "AuthorId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_AppBooks_AppAuthors_AuthorId",
            //    table: "AppBooks",
            //    column: "AuthorId",
            //    principalTable: "AppAuthors",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppBooks_AppAuthors_AuthorId",
                table: "AppBooks");

            migrationBuilder.DropTable(
                name: "AppBookTranslations");

            migrationBuilder.DropIndex(
                name: "IX_AppBooks_AuthorId",
                table: "AppBooks");
        }
    }
}
