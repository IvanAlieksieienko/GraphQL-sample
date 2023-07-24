﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SampleHeroesWebAPI.Data.ContextConfigurations;

#nullable disable

namespace SampleHeroesWebAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("SampleHeroesWebAPI.Models.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Instructor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SuperheroId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SuperheroId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bc4b6699-6b3a-4dab-8ed4-b6f98cb573e2"),
                            Description = "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,",
                            Instructor = "Christopher Nolan",
                            ReleaseDate = new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("61cb9bf4-3d15-455e-8511-76d09c35e5a0"),
                            Title = "Batman Begins"
                        },
                        new
                        {
                            Id = new Guid("e2c8bdce-d634-42e1-b1a0-1d757d90bf9a"),
                            Description = "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.",
                            Instructor = "Christopher Nolan",
                            ReleaseDate = new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("61cb9bf4-3d15-455e-8511-76d09c35e5a0"),
                            Title = "The Dark Knight"
                        },
                        new
                        {
                            Id = new Guid("0dc27065-ffef-4347-86de-51b5418cf103"),
                            Description = "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.",
                            Instructor = "Christopher Nolan",
                            ReleaseDate = new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("61cb9bf4-3d15-455e-8511-76d09c35e5a0"),
                            Title = "The Dark Knight Rises"
                        },
                        new
                        {
                            Id = new Guid("600ad7fd-ce0e-424f-90f6-b2b4502400ff"),
                            Description = "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.",
                            Instructor = "George Lucas",
                            ReleaseDate = new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("689997b3-a72a-41bf-9e60-1158d525dc1a"),
                            Title = "Star Wars: Episode IV – A New Hope"
                        },
                        new
                        {
                            Id = new Guid("3e17d427-adae-427e-818b-72b1e328ba7c"),
                            Description = "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.",
                            Instructor = "Irvin Kershner",
                            ReleaseDate = new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("689997b3-a72a-41bf-9e60-1158d525dc1a"),
                            Title = "Star Wars: Episode V – The Empire Strikes Back"
                        },
                        new
                        {
                            Id = new Guid("4fd36696-e769-4ae7-a3ad-e5d3a92fdf3a"),
                            Description = "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.",
                            Instructor = "Richard Marquand",
                            ReleaseDate = new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("689997b3-a72a-41bf-9e60-1158d525dc1a"),
                            Title = "Star Wars: Episode VI – Return of the Jedi"
                        },
                        new
                        {
                            Id = new Guid("24dc0d2a-df9e-45bb-bcc0-bda2196e7079"),
                            Description = "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).",
                            Instructor = "Cate Shortland",
                            ReleaseDate = new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("900e3a4c-92b6-418c-b023-0f9d02fc0ab0"),
                            Title = "Black Widow"
                        });
                });

            modelBuilder.Entity("SampleHeroesWebAPI.Models.Superhero", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Height")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Superheros");

                    b.HasData(
                        new
                        {
                            Id = new Guid("61cb9bf4-3d15-455e-8511-76d09c35e5a0"),
                            Description = "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.",
                            Height = "1.93",
                            Name = "Batman"
                        },
                        new
                        {
                            Id = new Guid("689997b3-a72a-41bf-9e60-1158d525dc1a"),
                            Description = "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.",
                            Height = "1.70",
                            Name = "Luke Skywalker"
                        },
                        new
                        {
                            Id = new Guid("900e3a4c-92b6-418c-b023-0f9d02fc0ab0"),
                            Description = "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.",
                            Height = "1.70",
                            Name = "Black Widow"
                        });
                });

            modelBuilder.Entity("SampleHeroesWebAPI.Models.Superpower", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SuperPower")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SuperheroId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SuperheroId");

                    b.ToTable("Superpowers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7cc1326d-b49d-4be2-8d9f-ef4708fdb906"),
                            Description = "He's always a step ahead.",
                            SuperPower = "Intellect.",
                            SuperheroId = new Guid("61cb9bf4-3d15-455e-8511-76d09c35e5a0")
                        },
                        new
                        {
                            Id = new Guid("d6c7868e-42a0-465b-bf62-53263d760bf8"),
                            Description = "Sublime fighting skills.",
                            SuperPower = "Fighting",
                            SuperheroId = new Guid("61cb9bf4-3d15-455e-8511-76d09c35e5a0")
                        },
                        new
                        {
                            Id = new Guid("1371d0cd-0ad4-4c78-8559-5e7a30aa1b3e"),
                            Description = "He got a lot of money",
                            SuperPower = "Wealth.",
                            SuperheroId = new Guid("61cb9bf4-3d15-455e-8511-76d09c35e5a0")
                        },
                        new
                        {
                            Id = new Guid("2724bcbc-18de-4233-9760-ef21b9fe6725"),
                            Description = "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.",
                            SuperPower = "Deflect blaster power.",
                            SuperheroId = new Guid("689997b3-a72a-41bf-9e60-1158d525dc1a")
                        },
                        new
                        {
                            Id = new Guid("a6ab474f-8ada-4511-8d91-e75495f2e03a"),
                            Description = "She's good at spying at people.",
                            SuperPower = "Espionage",
                            SuperheroId = new Guid("900e3a4c-92b6-418c-b023-0f9d02fc0ab0")
                        },
                        new
                        {
                            Id = new Guid("27eb6d55-9dbc-476f-8a61-02b79144ed85"),
                            Description = "She knows how to infiltrate the enemy.",
                            SuperPower = "Infiltration",
                            SuperheroId = new Guid("900e3a4c-92b6-418c-b023-0f9d02fc0ab0")
                        },
                        new
                        {
                            Id = new Guid("089305a8-81f3-4f10-991a-f90be9705615"),
                            Description = "The knowledge of how to undermine others.",
                            SuperPower = "Subterfuge",
                            SuperheroId = new Guid("900e3a4c-92b6-418c-b023-0f9d02fc0ab0")
                        });
                });

            modelBuilder.Entity("SampleHeroesWebAPI.Models.Movie", b =>
                {
                    b.HasOne("SampleHeroesWebAPI.Models.Superhero", "Superhero")
                        .WithMany("Movies")
                        .HasForeignKey("SuperheroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Superhero");
                });

            modelBuilder.Entity("SampleHeroesWebAPI.Models.Superpower", b =>
                {
                    b.HasOne("SampleHeroesWebAPI.Models.Superhero", "Superhero")
                        .WithMany("Superpowers")
                        .HasForeignKey("SuperheroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Superhero");
                });

            modelBuilder.Entity("SampleHeroesWebAPI.Models.Superhero", b =>
                {
                    b.Navigation("Movies");

                    b.Navigation("Superpowers");
                });
#pragma warning restore 612, 618
        }
    }
}
