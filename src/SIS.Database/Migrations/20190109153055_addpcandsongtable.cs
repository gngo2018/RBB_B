using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RedStarter.Database.Migrations
{
    public partial class addpcandsongtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlaylistCollectionTableAccess",
                columns: table => new
                {
                    PlaylistCollectionEntityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PlaylistId = table.Column<int>(nullable: false),
                    SongId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaylistCollectionTableAccess", x => x.PlaylistCollectionEntityId);
                });

            migrationBuilder.CreateTable(
                name: "SongTableAccess",
                columns: table => new
                {
                    SongEntityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GoogleId = table.Column<int>(nullable: false),
                    OwnerId = table.Column<int>(nullable: false),
                    SongTitle = table.Column<string>(nullable: false),
                    SongArtist = table.Column<string>(nullable: false),
                    SongLength = table.Column<string>(nullable: true),
                    SongAlbum = table.Column<string>(nullable: true),
                    SongGenre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SongTableAccess", x => x.SongEntityId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlaylistCollectionTableAccess");

            migrationBuilder.DropTable(
                name: "SongTableAccess");
        }
    }
}
