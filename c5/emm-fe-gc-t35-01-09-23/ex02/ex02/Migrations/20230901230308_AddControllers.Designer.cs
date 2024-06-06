﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ex02.Data;

#nullable disable

namespace ex02.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230901230308_AddControllers")]
    partial class AddControllers
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ex02.Models.Asignado_A", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CientificoDni")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)");

                    b.Property<string>("ProyectoId")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("varchar(4)");

                    b.HasKey("Id");

                    b.HasIndex("CientificoDni");

                    b.HasIndex("ProyectoId");

                    b.ToTable("Asignados");
                });

            modelBuilder.Entity("ex02.Models.Cientifico", b =>
                {
                    b.Property<string>("Dni")
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)");

                    b.Property<string>("NomApels")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Dni");

                    b.ToTable("Cientificos");
                });

            modelBuilder.Entity("ex02.Models.Proyecto", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(4)
                        .HasColumnType("varchar(4)");

                    b.Property<int>("Horas")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Proyectos");
                });

            modelBuilder.Entity("ex02.Models.Asignado_A", b =>
                {
                    b.HasOne("ex02.Models.Cientifico", "Cientifico")
                        .WithMany("Asignados")
                        .HasForeignKey("CientificoDni")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ex02.Models.Proyecto", "Proyecto")
                        .WithMany("Asignados")
                        .HasForeignKey("ProyectoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cientifico");

                    b.Navigation("Proyecto");
                });

            modelBuilder.Entity("ex02.Models.Cientifico", b =>
                {
                    b.Navigation("Asignados");
                });

            modelBuilder.Entity("ex02.Models.Proyecto", b =>
                {
                    b.Navigation("Asignados");
                });
#pragma warning restore 612, 618
        }
    }
}
