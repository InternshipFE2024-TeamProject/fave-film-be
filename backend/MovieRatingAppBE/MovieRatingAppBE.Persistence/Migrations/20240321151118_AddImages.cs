using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieRatingAppBE.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagesUrls",
                value: "[\"https://m.media-amazon.com/images/M/MV5BMjA3NzI1ODc1MV5BMl5BanBnXkFtZTcwMzI5NjQwNg@@._V1_.jpg\",\"https://m.media-amazon.com/images/M/MV5BMTU4NTY2NDU3Ml5BMl5BanBnXkFtZTcwMjQ1MTE5Ng@@._V1_.jpg\",\"https://static.cinemagia.ro/img/db/movie/55/89/90/in-time-690990l.jpg\"]");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagesUrls",
                value: "[\"https://m.media-amazon.com/images/M/MV5BOWRiZDIxZjktMTA1NC00MDQ2LWEzMjUtMTliZmY3NjQ3ODJiXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_FMjpg_UX1000_.jpg\",\"https://m.media-amazon.com/images/M/MV5BMTMxMTUzOTYxNF5BMl5BanBnXkFtZTcwNDYxMTIyMw@@._V1_.jpg\",\"https://filmforum.org/do-not-enter-or-modify-or-erase/client-uploads/_1000w/THE_PIANIST_slideshow_3.png\"]");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagesUrls",
                value: "[\"https://elranchito.es/wp-content/uploads/2023/12/MV5BYWQ0Y2MxODgtOWI0ZC00MWIwLWIyYzEtN2FhNWQ1MGQ3MDBhXkEyXkFqcGdeQXVyMTUzMTg2ODkz._V1_.jpg\",\"https://variety.com/wp-content/uploads/2023/07/Society-of-the-Snow.jpg?w=1000\",\"https://m.media-amazon.com/images/M/MV5BZWQwYTljYWEtOThjZS00NmI5LWFmZTAtNDcyZjAwY2MxNjRjXkEyXkFqcGdeQXVyMDc2NTEzMw@@._V1_.jpg\"]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagesUrls",
                value: "[\"https://www.imdb.com/title/tt1637688/mediaviewer/rm1617280768/?ref_=tt_ov_i\",\"https://www.imdb.com/title/tt1637688/mediaviewer/rm3689329152/?ref_=tt_md_3\",\"https://www.imdb.com/title/tt1637688/mediaviewer/rm3672551936/?ref_=tt_md_4\"]");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagesUrls",
                value: "[\"https://www.imdb.com/title/tt0253474/mediaviewer/rm902038272/?ref_=tt_ov_i\",\"https://www.imdb.com/title/tt0253474/mediaviewer/rm1931906816/?ref_=tt_md_3\",\"https://www.imdb.com/title/tt0253474/mediaviewer/rm1680248576/?ref_=tt_md_8\"]");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagesUrls",
                value: "[\"https://www.imdb.com/title/tt16277242/mediaviewer/rm2344241665/?ref_=tt_ov_i\",\"https://www.imdb.com/title/tt16277242/mediaviewer/rm1905282561/?ref_=tt_md_1\",\"https://www.imdb.com/title/tt16277242/mediaviewer/rm1888505345/?ref_=tt_md_2\"]");
        }
    }
}
