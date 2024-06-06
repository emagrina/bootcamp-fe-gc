﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ex04.Data;

#nullable disable

namespace ex04.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230901145059_AddModelsSalasAndPeliculas")]
    partial class AddModelsSalasAndPeliculas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ex04.Models.Pelicula", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CalificacionEdad")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Codigo");

                    b.ToTable("Peliculas");
                });

            modelBuilder.Entity("ex04.Models.Sala", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("PeliculaCodigo")
                        .HasColumnType("int");

                    b.HasKey("Codigo");

                    b.HasIndex("PeliculaCodigo");

                    b.ToTable("Salas");
                });

            modelBuilder.Entity("ex04.Models.Sala", b =>
                {
                    b.HasOne("ex04.Models.Pelicula", "Pelicula")
                        .WithMany("Salas")
                        .HasForeignKey("PeliculaCodigo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pelicula");
                });

            modelBuilder.Entity("ex04.Models.Pelicula", b =>
                {
                    b.Navigation("Salas");
                });
#pragma warning restore 612, 618
        }
    }
}
