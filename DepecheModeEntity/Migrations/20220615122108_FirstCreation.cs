using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DepecheModeEntity.Migrations
{
    public partial class FirstCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlbumId = table.Column<int>(type: "int", nullable: false),
                    MusicVideo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "Name", "Year" },
                values: new object[,]
                {
                    { 1, "Speak & Spell", 1981 },
                    { 2, "A Broken Frame", 1982 },
                    { 3, "Construction Time Again", 1983 },
                    { 4, "Some Great Reward", 1984 },
                    { 5, "Black Celebration", 1986 },
                    { 6, "Music for The Masses", 1987 },
                    { 7, "Violator", 1990 },
                    { 8, "Songs of Faith and Devotion", 1993 },
                    { 9, "ULTRA", 1997 },
                    { 10, "Exciter", 2001 },
                    { 11, "Playing the Angel", 2005 },
                    { 12, "Sounds of the Universe", 2009 },
                    { 13, "Delta Machine", 2013 },
                    { 14, "Spirit", 2017 }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "MusicVideo", "Name" },
                values: new object[,]
                {
                    { 1, 7, true, "Enjoy the Silence" },
                    { 2, 9, true, "Barrel of a Gun" },
                    { 3, 4, true, "Lie to Me" },
                    { 4, 13, true, "Angel" },
                    { 5, 5, true, "Black Celebration" },
                    { 6, 4, false, "It doesn't matter" },
                    { 7, 9, false, "Sister of Night" },
                    { 8, 10, false, "Sweetest Condition" },
                    { 9, 5, true, "But Not Tonight" },
                    { 10, 6, false, "Nothing" },
                    { 11, 3, true, "Everything Counts" },
                    { 12, 2, true, "See You" },
                    { 13, 1, false, "Photographic" },
                    { 14, 11, false, "Nothing's Impossible" },
                    { 15, 8, false, "Rush" },
                    { 16, 7, false, "One Caress" },
                    { 17, 4, false, "Work Hard" },
                    { 18, 12, true, "Wrong" },
                    { 19, 14, true, "Where's the Revolution" },
                    { 20, 6, true, "Behind the Wheel" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Songs");
        }
    }
}
