// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backend.Data;

namespace backend.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("backend.Model.Game", b =>
                {
                    b.Property<long>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Developer")
                        .HasColumnType("longtext");

                    b.Property<string>("Gender")
                        .HasColumnType("longtext");

                    b.Property<string>("ImageLink")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<long?>("PageId")
                        .HasColumnType("bigint");

                    b.Property<long>("Popularity")
                        .HasColumnType("bigint");

                    b.HasKey("GameId");

                    b.HasIndex("PageId");

                    b.ToTable("games");
                });

            modelBuilder.Entity("backend.Model.Page", b =>
                {
                    b.Property<long>("PageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("GameId")
                        .HasColumnType("bigint");

                    b.Property<string>("LinkYoutube")
                        .HasColumnType("longtext");

                    b.Property<string>("MainPage")
                        .HasColumnType("longtext");

                    b.Property<string>("Podcast")
                        .HasColumnType("longtext");

                    b.Property<string>("ReleaseNotes")
                        .HasColumnType("longtext");

                    b.Property<string>("Updates")
                        .HasColumnType("longtext");

                    b.Property<string>("longDescription")
                        .HasColumnType("longtext");

                    b.Property<string>("platforms")
                        .HasColumnType("longtext");

                    b.HasKey("PageId");

                    b.ToTable("pages");
                });

            modelBuilder.Entity("backend.Model.User", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<bool>("Admin")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("GenrePreferred")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Registered")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UserName")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.HasKey("UserId");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            UserId = 1L,
                            Admin = true,
                            Email = "teste@teste",
                            GenrePreferred = "FPS",
                            Password = "teste",
                            Registered = new DateTime(2021, 6, 20, 20, 40, 42, 688, DateTimeKind.Local).AddTicks(9354),
                            UserName = "Mateus"
                        },
                        new
                        {
                            UserId = 2L,
                            Admin = true,
                            Email = "teste@teste",
                            GenrePreferred = "FPS",
                            Password = "teste",
                            Registered = new DateTime(2021, 6, 20, 20, 40, 42, 689, DateTimeKind.Local).AddTicks(879),
                            UserName = "teste"
                        },
                        new
                        {
                            UserId = 3L,
                            Admin = true,
                            Email = "teste@teste",
                            GenrePreferred = "FPS",
                            Password = "teste",
                            Registered = new DateTime(2021, 6, 20, 20, 40, 42, 689, DateTimeKind.Local).AddTicks(890),
                            UserName = "alner"
                        });
                });

            modelBuilder.Entity("backend.Model.Game", b =>
                {
                    b.HasOne("backend.Model.Page", "page")
                        .WithMany()
                        .HasForeignKey("PageId");

                    b.Navigation("page");
                });
#pragma warning restore 612, 618
        }
    }
}
