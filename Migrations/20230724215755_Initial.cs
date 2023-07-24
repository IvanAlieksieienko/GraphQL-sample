﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SampleHeroesWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Superheros",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Height = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Superheros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Instructor = table.Column<string>(type: "TEXT", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SuperheroId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Superheros_SuperheroId",
                        column: x => x.SuperheroId,
                        principalTable: "Superheros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Superpowers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    SuperPower = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    SuperheroId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Superpowers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Superpowers_Superheros_SuperheroId",
                        column: x => x.SuperheroId,
                        principalTable: "Superheros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Superheros",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[,]
                {
                    { new Guid("61cb9bf4-3d15-455e-8511-76d09c35e5a0"), "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.", "1.93", "Batman" },
                    { new Guid("689997b3-a72a-41bf-9e60-1158d525dc1a"), "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.", "1.70", "Luke Skywalker" },
                    { new Guid("900e3a4c-92b6-418c-b023-0f9d02fc0ab0"), "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.", "1.70", "Black Widow" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "SuperheroId", "Title" },
                values: new object[,]
                {
                    { new Guid("0dc27065-ffef-4347-86de-51b5418cf103"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("61cb9bf4-3d15-455e-8511-76d09c35e5a0"), "The Dark Knight Rises" },
                    { new Guid("24dc0d2a-df9e-45bb-bcc0-bda2196e7079"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("900e3a4c-92b6-418c-b023-0f9d02fc0ab0"), "Black Widow" },
                    { new Guid("3e17d427-adae-427e-818b-72b1e328ba7c"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("689997b3-a72a-41bf-9e60-1158d525dc1a"), "Star Wars: Episode V – The Empire Strikes Back" },
                    { new Guid("4fd36696-e769-4ae7-a3ad-e5d3a92fdf3a"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("689997b3-a72a-41bf-9e60-1158d525dc1a"), "Star Wars: Episode VI – Return of the Jedi" },
                    { new Guid("600ad7fd-ce0e-424f-90f6-b2b4502400ff"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("689997b3-a72a-41bf-9e60-1158d525dc1a"), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("bc4b6699-6b3a-4dab-8ed4-b6f98cb573e2"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("61cb9bf4-3d15-455e-8511-76d09c35e5a0"), "Batman Begins" },
                    { new Guid("e2c8bdce-d634-42e1-b1a0-1d757d90bf9a"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("61cb9bf4-3d15-455e-8511-76d09c35e5a0"), "The Dark Knight" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower", "SuperheroId" },
                values: new object[,]
                {
                    { new Guid("089305a8-81f3-4f10-991a-f90be9705615"), "The knowledge of how to undermine others.", "Subterfuge", new Guid("900e3a4c-92b6-418c-b023-0f9d02fc0ab0") },
                    { new Guid("1371d0cd-0ad4-4c78-8559-5e7a30aa1b3e"), "He got a lot of money", "Wealth.", new Guid("61cb9bf4-3d15-455e-8511-76d09c35e5a0") },
                    { new Guid("2724bcbc-18de-4233-9760-ef21b9fe6725"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power.", new Guid("689997b3-a72a-41bf-9e60-1158d525dc1a") },
                    { new Guid("27eb6d55-9dbc-476f-8a61-02b79144ed85"), "She knows how to infiltrate the enemy.", "Infiltration", new Guid("900e3a4c-92b6-418c-b023-0f9d02fc0ab0") },
                    { new Guid("7cc1326d-b49d-4be2-8d9f-ef4708fdb906"), "He's always a step ahead.", "Intellect.", new Guid("61cb9bf4-3d15-455e-8511-76d09c35e5a0") },
                    { new Guid("a6ab474f-8ada-4511-8d91-e75495f2e03a"), "She's good at spying at people.", "Espionage", new Guid("900e3a4c-92b6-418c-b023-0f9d02fc0ab0") },
                    { new Guid("d6c7868e-42a0-465b-bf62-53263d760bf8"), "Sublime fighting skills.", "Fighting", new Guid("61cb9bf4-3d15-455e-8511-76d09c35e5a0") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_SuperheroId",
                table: "Movies",
                column: "SuperheroId");

            migrationBuilder.CreateIndex(
                name: "IX_Superpowers_SuperheroId",
                table: "Superpowers",
                column: "SuperheroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Superpowers");

            migrationBuilder.DropTable(
                name: "Superheros");
        }
    }
}
