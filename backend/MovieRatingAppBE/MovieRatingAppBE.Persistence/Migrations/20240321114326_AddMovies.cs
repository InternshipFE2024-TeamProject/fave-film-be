using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieRatingAppBE.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddMovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImagesUlrs",
                table: "Movies",
                newName: "ImagesUrls");

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Cast", "Description", "Director", "Genres", "ImagesUrls", "Title" },
                values: new object[,]
                {
                    { 1, "[\"Justin Timberlake\",\"Cillian Murphy\",\"Amanda Seyfried\"]", "In a future where people stop aging at 25, but are engineered to live only one more year, having the means to buy your way out of the situation is a shot at immortal youth. Here, Will Salas finds himself accused of murder and on the run with a hostage - a connection that becomes an important part of the way against the system.", "Andrew Niccol", "[\"Science Fiction\",\"Thriller\",\"Action\"]", "[\"https://www.imdb.com/title/tt1637688/mediaviewer/rm1617280768/?ref_=tt_ov_i\",\"https://www.imdb.com/title/tt1637688/mediaviewer/rm3689329152/?ref_=tt_md_3\",\"https://www.imdb.com/title/tt1637688/mediaviewer/rm3672551936/?ref_=tt_md_4\"]", "In Time" },
                    { 2, "[\"Adrien Brody\",\"Thomas Kretschmann\",\"Frank Finlay\"]", "During WWII, acclaimed Polish musician Wladyslaw faces various struggles as he loses contact with his family. As the situation worsens, he hides in the ruins of Warsaw in order to survive.", "Roman Polanski", "[\"Biography\",\"Drama\",\"Music\"]", "[\"https://www.imdb.com/title/tt0253474/mediaviewer/rm902038272/?ref_=tt_ov_i\",\"https://www.imdb.com/title/tt0253474/mediaviewer/rm1931906816/?ref_=tt_md_3\",\"https://www.imdb.com/title/tt0253474/mediaviewer/rm1680248576/?ref_=tt_md_8\"]", "The Pianist" },
                    { 3, "[\"Enzo Vogrincic\",\"Agust\\u00EDn Pardella\",\"Mat\\u00EDas Recalt\"]", "The flight of a rugby team crashes on a glacier in the Andes. The few passengers who survive the crash find themselves in one of the world's toughest environments to survive.", "J.A. Bayona", "[\"Adventure\",\"Biography\",\"Drama\"]", "[\"https://www.imdb.com/title/tt16277242/mediaviewer/rm2344241665/?ref_=tt_ov_i\",\"https://www.imdb.com/title/tt16277242/mediaviewer/rm1905282561/?ref_=tt_md_1\",\"https://www.imdb.com/title/tt16277242/mediaviewer/rm1888505345/?ref_=tt_md_2\"]", "Society of the Snow" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "ImagesUrls",
                table: "Movies",
                newName: "ImagesUlrs");
        }
    }
}
