﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieRatingAppBE.Persistence.Data;

#nullable disable

namespace MovieRatingAppBE.Persistence.Migrations
{
    [DbContext(typeof(MovieRatingContext))]
    [Migration("20240321114326_AddMovies")]
    partial class AddMovies
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MovieRatingAppBE.Domain.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cast")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagesUrls")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cast = "[\"Justin Timberlake\",\"Cillian Murphy\",\"Amanda Seyfried\"]",
                            Description = "In a future where people stop aging at 25, but are engineered to live only one more year, having the means to buy your way out of the situation is a shot at immortal youth. Here, Will Salas finds himself accused of murder and on the run with a hostage - a connection that becomes an important part of the way against the system.",
                            Director = "Andrew Niccol",
                            Genres = "[\"Science Fiction\",\"Thriller\",\"Action\"]",
                            ImagesUrls = "[\"https://www.imdb.com/title/tt1637688/mediaviewer/rm1617280768/?ref_=tt_ov_i\",\"https://www.imdb.com/title/tt1637688/mediaviewer/rm3689329152/?ref_=tt_md_3\",\"https://www.imdb.com/title/tt1637688/mediaviewer/rm3672551936/?ref_=tt_md_4\"]",
                            Title = "In Time"
                        },
                        new
                        {
                            Id = 2,
                            Cast = "[\"Adrien Brody\",\"Thomas Kretschmann\",\"Frank Finlay\"]",
                            Description = "During WWII, acclaimed Polish musician Wladyslaw faces various struggles as he loses contact with his family. As the situation worsens, he hides in the ruins of Warsaw in order to survive.",
                            Director = "Roman Polanski",
                            Genres = "[\"Biography\",\"Drama\",\"Music\"]",
                            ImagesUrls = "[\"https://www.imdb.com/title/tt0253474/mediaviewer/rm902038272/?ref_=tt_ov_i\",\"https://www.imdb.com/title/tt0253474/mediaviewer/rm1931906816/?ref_=tt_md_3\",\"https://www.imdb.com/title/tt0253474/mediaviewer/rm1680248576/?ref_=tt_md_8\"]",
                            Title = "The Pianist"
                        },
                        new
                        {
                            Id = 3,
                            Cast = "[\"Enzo Vogrincic\",\"Agust\\u00EDn Pardella\",\"Mat\\u00EDas Recalt\"]",
                            Description = "The flight of a rugby team crashes on a glacier in the Andes. The few passengers who survive the crash find themselves in one of the world's toughest environments to survive.",
                            Director = "J.A. Bayona",
                            Genres = "[\"Adventure\",\"Biography\",\"Drama\"]",
                            ImagesUrls = "[\"https://www.imdb.com/title/tt16277242/mediaviewer/rm2344241665/?ref_=tt_ov_i\",\"https://www.imdb.com/title/tt16277242/mediaviewer/rm1905282561/?ref_=tt_md_1\",\"https://www.imdb.com/title/tt16277242/mediaviewer/rm1888505345/?ref_=tt_md_2\"]",
                            Title = "Society of the Snow"
                        });
                });

            modelBuilder.Entity("MovieRatingAppBE.Domain.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("MovieRatingAppBE.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MovieUser", b =>
                {
                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.Property<int>("WatchedListId")
                        .HasColumnType("int");

                    b.HasKey("UsersId", "WatchedListId");

                    b.HasIndex("WatchedListId");

                    b.ToTable("MovieUser");
                });

            modelBuilder.Entity("MovieRatingAppBE.Domain.Review", b =>
                {
                    b.HasOne("MovieRatingAppBE.Domain.Movie", null)
                        .WithMany("Reviews")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieRatingAppBE.Domain.User", null)
                        .WithMany("ReviewsList")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MovieUser", b =>
                {
                    b.HasOne("MovieRatingAppBE.Domain.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieRatingAppBE.Domain.Movie", null)
                        .WithMany()
                        .HasForeignKey("WatchedListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MovieRatingAppBE.Domain.Movie", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("MovieRatingAppBE.Domain.User", b =>
                {
                    b.Navigation("ReviewsList");
                });
#pragma warning restore 612, 618
        }
    }
}