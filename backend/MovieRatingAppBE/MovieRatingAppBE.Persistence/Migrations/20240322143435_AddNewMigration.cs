using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieRatingAppBE.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddNewMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Cast", "Description", "Director", "Genres", "ImagesUrls", "Title" },
                values: new object[,]
                {
                    { 4, "[\"Miyu Irino\",\"Rumi Hiiragi\",\"Mari Natsuki\"]", "During her family's move to the suburbs, a sullen 10-year-old girl wanders into a world ruled by gods, witches and spirits, a world where humans are changed into beasts.", "Hayao Miyazaki", "[\"Animation\",\"Adventure\",\"Family\"]", "[\"https://m.media-amazon.com/images/M/MV5BMjlmZmI5MDctNDE2YS00YWE0LWE5ZWItZDBhYWQ0NTcxNWRhXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_.jpg\",\"https://m.media-amazon.com/images/M/MV5BMjE1Mjk2MTcwNV5BMl5BanBnXkFtZTgwNTc1MTMyMDE@._V1_.jpg\",\"https://www.fortressofsolitude.co.za/wp-content/uploads/2021/04/spirited-away-no-face.jpg\"]", "Spirited Away" },
                    { 5, "[\"Margot Robbie\",\"Ryan Gosling\",\"Simu Liu\"]", "Barbie and Ken are having the time of their lives in the colorful and seemingly perfect world of Barbie Land. However, when they get a chance to go to the real world, they soon discover the joys and perils of living among humans.", "Greta Gerwig", "[\"Adventure\",\"Comedy\",\"Fantasy\"]", "[\"https://i.ebayimg.com/images/g/O3MAAOSwiZ9k0HfD/s-l1600.jpg\",\"https://www.barbie-themovie.com/images/share.jpg\",\"https://hips.hearstapps.com/hmg-prod/images/barbie-movie-film-64b9625d145c1.jpeg\"]", "Barbie" },
                    { 6, "[\"Matthew McConaughey\",\"Anne Hathaway\",\"Jessica Chastain\"]", "When Earth becomes uninhabitable in the future, a farmer and ex-NASA pilot, Joseph Cooper, is tasked to pilot a spacecraft, along with a team of researchers, to find a new planet for humans.", "Christopher Nolan", "[\"Adventure\",\"Drama\",\"Science Fiction\"]", "[\"https://m.media-amazon.com/images/M/MV5BZjdkOTU3MDktN2IxOS00OGEyLWFmMjktY2FiMmZkNWIyODZiXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_.jpg\",\"https://www.denofgeek.com/wp-content/uploads/2022/02/spaceship-and-black-hole-in-Interstellar.jpeg?fit=1800%2C1125\",\"https://cdn.mos.cms.futurecdn.net/LVoJnXBbUH6xx9EkfgVnc5.jpg\"]", "Interstellar" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password" },
                values: new object[] { 1, "my@email.com", "Robert", "Domokos", "pass" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
