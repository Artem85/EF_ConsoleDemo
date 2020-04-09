﻿// <auto-generated />
using DemoConsole.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DemoConsole.Migrations
{
    [DbContext(typeof(ActorDbContext))]
    [Migration("20200409215250_DataSeeding")]
    partial class DataSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DemoConsole.Entities.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("Age")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasColumnName("FullName")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = (byte)55,
                            Name = "Jack Nicholson"
                        },
                        new
                        {
                            Id = 2,
                            Age = (byte)68,
                            Name = "Marlon Brando"
                        },
                        new
                        {
                            Id = 3,
                            Age = (byte)54,
                            Name = "Robert De Niro"
                        },
                        new
                        {
                            Id = 4,
                            Age = (byte)64,
                            Name = "Al Pacino"
                        },
                        new
                        {
                            Id = 5,
                            Age = (byte)55,
                            Name = "Tom Hanks"
                        },
                        new
                        {
                            Id = 6,
                            Age = (byte)66,
                            Name = "Anthony Hopkins"
                        },
                        new
                        {
                            Id = 7,
                            Age = (byte)60,
                            Name = "Denzel Washington"
                        },
                        new
                        {
                            Id = 8,
                            Age = (byte)61,
                            Name = "Morgan Freeman"
                        },
                        new
                        {
                            Id = 9,
                            Age = (byte)70,
                            Name = "Clint Eastwood"
                        },
                        new
                        {
                            Id = 10,
                            Age = (byte)30,
                            Name = "Leonardo DiCaprio"
                        });
                });

            modelBuilder.Entity("DemoConsole.Entities.ActorMovie", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("ActorId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("ActorMovie");

                    b.HasData(
                        new
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                        new
                        {
                            ActorId = 2,
                            MovieId = 2
                        },
                        new
                        {
                            ActorId = 3,
                            MovieId = 2
                        },
                        new
                        {
                            ActorId = 5,
                            MovieId = 2
                        },
                        new
                        {
                            ActorId = 6,
                            MovieId = 2
                        },
                        new
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new
                        {
                            ActorId = 4,
                            MovieId = 3
                        },
                        new
                        {
                            ActorId = 8,
                            MovieId = 3
                        },
                        new
                        {
                            ActorId = 9,
                            MovieId = 3
                        },
                        new
                        {
                            ActorId = 10,
                            MovieId = 3
                        },
                        new
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new
                        {
                            ActorId = 4,
                            MovieId = 4
                        },
                        new
                        {
                            ActorId = 7,
                            MovieId = 4
                        },
                        new
                        {
                            ActorId = 8,
                            MovieId = 4
                        },
                        new
                        {
                            ActorId = 9,
                            MovieId = 4
                        },
                        new
                        {
                            ActorId = 10,
                            MovieId = 4
                        });
                });

            modelBuilder.Entity("DemoConsole.Entities.Award", b =>
                {
                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(15)");

                    b.Property<short>("DeliveryYear")
                        .HasColumnName("Year")
                        .HasColumnType("smallint");

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.HasKey("Title", "DeliveryYear");

                    b.HasIndex("ActorId");

                    b.ToTable("Awards");

                    b.HasData(
                        new
                        {
                            Title = "Oscar",
                            DeliveryYear = (short)2018,
                            ActorId = 1
                        },
                        new
                        {
                            Title = "Oscar",
                            DeliveryYear = (short)2019,
                            ActorId = 2
                        },
                        new
                        {
                            Title = "GoldenGlobe",
                            DeliveryYear = (short)2018,
                            ActorId = 3
                        },
                        new
                        {
                            Title = "GoldenGlobe",
                            DeliveryYear = (short)2019,
                            ActorId = 1
                        },
                        new
                        {
                            Title = "BAFTA",
                            DeliveryYear = (short)2018,
                            ActorId = 2
                        },
                        new
                        {
                            Title = "BAFTA",
                            DeliveryYear = (short)2019,
                            ActorId = 1
                        });
                });

            modelBuilder.Entity("DemoConsole.Entities.Director", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("FullName")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Directors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Steven Spielberg"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Martin Scorsese"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Quentin Jerome Tarantino"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Christopher Jonathan James Nolan"
                        });
                });

            modelBuilder.Entity("DemoConsole.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DirectorId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("DirectorId")
                        .IsUnique();

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DirectorId = 1,
                            Title = "Jaws"
                        },
                        new
                        {
                            Id = 2,
                            DirectorId = 2,
                            Title = "The Wolf of Wall Street"
                        },
                        new
                        {
                            Id = 3,
                            DirectorId = 3,
                            Title = "Pulp Fiction"
                        },
                        new
                        {
                            Id = 4,
                            DirectorId = 4,
                            Title = "Interstellar"
                        });
                });

            modelBuilder.Entity("DemoConsole.Entities.ActorMovie", b =>
                {
                    b.HasOne("DemoConsole.Entities.Actor", "Actor")
                        .WithMany("ActorMovies")
                        .HasForeignKey("ActorId")
                        .HasConstraintName("Awarded")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DemoConsole.Entities.Movie", "Movie")
                        .WithMany("ActorMovies")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DemoConsole.Entities.Award", b =>
                {
                    b.HasOne("DemoConsole.Entities.Actor", "Actor")
                        .WithMany("Awards")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DemoConsole.Entities.Movie", b =>
                {
                    b.HasOne("DemoConsole.Entities.Director", "Director")
                        .WithOne("Movie")
                        .HasForeignKey("DemoConsole.Entities.Movie", "DirectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}