﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TMDB.MVC.Data;

#nullable disable

namespace TMDB.MVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TMDB.MVC.Models.CastDbo", b =>
                {
                    b.Property<int?>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("id"), 1L, 1);

                    b.Property<int>("CreditsDboId")
                        .HasColumnType("int");

                    b.Property<bool?>("adult")
                        .HasColumnType("bit");

                    b.Property<int?>("cast_id")
                        .HasColumnType("int");

                    b.Property<string>("character")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("credit_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("gender")
                        .HasColumnType("int");

                    b.Property<string>("known_for_department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("order")
                        .HasColumnType("int");

                    b.Property<string>("original_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("popularity")
                        .HasColumnType("float");

                    b.Property<string>("profile_path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("CreditsDboId");

                    b.ToTable("CastDbo");
                });

            modelBuilder.Entity("TMDB.MVC.Models.CreditsDbo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.HasKey("id");

                    b.ToTable("CreditsDbo");
                });

            modelBuilder.Entity("TMDB.MVC.Models.CrewDbo", b =>
                {
                    b.Property<int?>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("id"), 1L, 1);

                    b.Property<int>("CreditsDboId")
                        .HasColumnType("int");

                    b.Property<bool?>("adult")
                        .HasColumnType("bit");

                    b.Property<string>("credit_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("gender")
                        .HasColumnType("int");

                    b.Property<string>("job")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("known_for_department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("original_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("popularity")
                        .HasColumnType("float");

                    b.Property<string>("profile_path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("CreditsDboId");

                    b.ToTable("CrewDbo");
                });

            modelBuilder.Entity("TMDB.MVC.Models.GenreDbo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("MovieDetailsDboId")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("MovieDetailsDboId");

                    b.ToTable("GenreDbo");
                });

            modelBuilder.Entity("TMDB.MVC.Models.MovieDetailsDbo", b =>
                {
                    b.Property<int>("MovieDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieDetailsId"), 1L, 1);

                    b.Property<bool?>("adult")
                        .HasColumnType("bit");

                    b.Property<string>("backdrop_path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("budget")
                        .HasColumnType("int");

                    b.Property<string>("homepage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<string>("imdb_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("original_language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("original_title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("overview")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("popularity")
                        .HasColumnType("float");

                    b.Property<string>("poster_path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("release_date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("revenue")
                        .HasColumnType("int");

                    b.Property<int?>("runtime")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tagline")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("video")
                        .HasColumnType("bit");

                    b.Property<double?>("vote_average")
                        .HasColumnType("float");

                    b.Property<int?>("vote_count")
                        .HasColumnType("int");

                    b.HasKey("MovieDetailsId");

                    b.ToTable("MovieDetailsDbo");
                });

            modelBuilder.Entity("TMDB.MVC.Models.Movies", b =>
                {
                    b.Property<int>("MoviesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MoviesId"), 1L, 1);

                    b.Property<bool>("adult")
                        .HasColumnType("bit");

                    b.Property<string>("backdrop_path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<string>("original_language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("original_title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("overview")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("popularity")
                        .HasColumnType("float");

                    b.Property<string>("poster_path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("release_date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("video")
                        .HasColumnType("bit");

                    b.Property<double>("vote_average")
                        .HasColumnType("float");

                    b.Property<int>("vote_count")
                        .HasColumnType("int");

                    b.HasKey("MoviesId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("TMDB.MVC.Models.ProductionCompanyDbo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("MovieDetailsDboId")
                        .HasColumnType("int");

                    b.Property<string>("logo_path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("origin_country")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("MovieDetailsDboId");

                    b.ToTable("ProductionCompanyDbo");
                });

            modelBuilder.Entity("TMDB.MVC.Models.ProductionCountryDbo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("MovieDetailsDboId")
                        .HasColumnType("int");

                    b.Property<string>("iso_3166_1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("MovieDetailsDboId");

                    b.ToTable("ProductionCountryDbo");
                });

            modelBuilder.Entity("TMDB.MVC.Models.SpokenLanguageDbo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("MovieDetailsDboId")
                        .HasColumnType("int");

                    b.Property<string>("english_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("iso_639_1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("MovieDetailsDboId");

                    b.ToTable("SpokenLanguageDbo");
                });

            modelBuilder.Entity("TMDB.MVC.Models.CastDbo", b =>
                {
                    b.HasOne("TMDB.MVC.Models.CreditsDbo", "CreditsDbo")
                        .WithMany("cast")
                        .HasForeignKey("CreditsDboId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreditsDbo");
                });

            modelBuilder.Entity("TMDB.MVC.Models.CrewDbo", b =>
                {
                    b.HasOne("TMDB.MVC.Models.CreditsDbo", "CreditsDbo")
                        .WithMany("crew")
                        .HasForeignKey("CreditsDboId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreditsDbo");
                });

            modelBuilder.Entity("TMDB.MVC.Models.GenreDbo", b =>
                {
                    b.HasOne("TMDB.MVC.Models.MovieDetailsDbo", "MovieDetailsDbo")
                        .WithMany("genres")
                        .HasForeignKey("MovieDetailsDboId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MovieDetailsDbo");
                });

            modelBuilder.Entity("TMDB.MVC.Models.ProductionCompanyDbo", b =>
                {
                    b.HasOne("TMDB.MVC.Models.MovieDetailsDbo", "MovieDetailsDbo")
                        .WithMany("production_companies")
                        .HasForeignKey("MovieDetailsDboId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MovieDetailsDbo");
                });

            modelBuilder.Entity("TMDB.MVC.Models.ProductionCountryDbo", b =>
                {
                    b.HasOne("TMDB.MVC.Models.MovieDetailsDbo", "MovieDetailsDbo")
                        .WithMany("production_countries")
                        .HasForeignKey("MovieDetailsDboId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MovieDetailsDbo");
                });

            modelBuilder.Entity("TMDB.MVC.Models.SpokenLanguageDbo", b =>
                {
                    b.HasOne("TMDB.MVC.Models.MovieDetailsDbo", "MovieDetailsDbo")
                        .WithMany("spoken_languages")
                        .HasForeignKey("MovieDetailsDboId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MovieDetailsDbo");
                });

            modelBuilder.Entity("TMDB.MVC.Models.CreditsDbo", b =>
                {
                    b.Navigation("cast");

                    b.Navigation("crew");
                });

            modelBuilder.Entity("TMDB.MVC.Models.MovieDetailsDbo", b =>
                {
                    b.Navigation("genres");

                    b.Navigation("production_companies");

                    b.Navigation("production_countries");

                    b.Navigation("spoken_languages");
                });
#pragma warning restore 612, 618
        }
    }
}
