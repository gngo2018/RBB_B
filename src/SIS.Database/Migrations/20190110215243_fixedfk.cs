using Microsoft.EntityFrameworkCore.Migrations;

namespace RedStarter.Database.Migrations
{
    public partial class fixedfk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SongId",
                table: "PlaylistCollectionTableAccess",
                newName: "SongEntityId");

            migrationBuilder.RenameColumn(
                name: "PlaylistId",
                table: "PlaylistCollectionTableAccess",
                newName: "PlaylistEntityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SongEntityId",
                table: "PlaylistCollectionTableAccess",
                newName: "SongId");

            migrationBuilder.RenameColumn(
                name: "PlaylistEntityId",
                table: "PlaylistCollectionTableAccess",
                newName: "PlaylistId");
        }
    }
}
