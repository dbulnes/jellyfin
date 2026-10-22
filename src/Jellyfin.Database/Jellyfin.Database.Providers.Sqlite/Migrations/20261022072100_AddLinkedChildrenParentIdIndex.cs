using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jellyfin.Database.Providers.Sqlite.Migrations
{
    /// <inheritdoc />
    public partial class AddLinkedChildrenParentIdIndex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_LinkedChildren_ParentId",
                table: "LinkedChildren",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_AncestorIds_ParentItemId_ItemId",
                table: "AncestorIds",
                columns: new[] { "ParentItemId", "ItemId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_LinkedChildren_ParentId",
                table: "LinkedChildren");

            migrationBuilder.DropIndex(
                name: "IX_AncestorIds_ParentItemId_ItemId",
                table: "AncestorIds");
        }
    }
}
