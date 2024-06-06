﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ex01.Data;

#nullable disable

namespace ex01.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ex01.Models.Pieza", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Codigo");

                    b.ToTable("Piezas");
                });

            modelBuilder.Entity("ex01.Models.Proveedor", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(4)
                        .HasColumnType("varchar(4)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("ex01.Models.Suministra", b =>
                {
                    b.Property<int>("CodigoPieza")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<string>("IdProveedor")
                        .HasMaxLength(4)
                        .HasColumnType("varchar(4)")
                        .HasColumnOrder(1);

                    b.Property<double>("Precio")
                        .HasColumnType("double");

                    b.HasKey("CodigoPieza", "IdProveedor");

                    b.HasIndex("CodigoPieza")
                        .IsUnique();

                    b.HasIndex("IdProveedor")
                        .IsUnique();

                    b.ToTable("Suministra");
                });

            modelBuilder.Entity("ex01.Models.Suministra", b =>
                {
                    b.HasOne("ex01.Models.Pieza", "Pieza")
                        .WithOne("Suministra")
                        .HasForeignKey("ex01.Models.Suministra", "CodigoPieza")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ex01.Models.Proveedor", "Proveedor")
                        .WithOne("Suministra")
                        .HasForeignKey("ex01.Models.Suministra", "IdProveedor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pieza");

                    b.Navigation("Proveedor");
                });

            modelBuilder.Entity("ex01.Models.Pieza", b =>
                {
                    b.Navigation("Suministra");
                });

            modelBuilder.Entity("ex01.Models.Proveedor", b =>
                {
                    b.Navigation("Suministra");
                });
#pragma warning restore 612, 618
        }
    }
}
