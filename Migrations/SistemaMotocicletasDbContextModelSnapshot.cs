// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaMotocicletas.Data;

#nullable disable

namespace SistemaMotocicletas.Migrations
{
    [DbContext(typeof(SistemaMotocicletasDbContext))]
    partial class SistemaMotocicletasDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SistemaMotocicletas.Models.Motocicleta", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CCMotocicleta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaDeIngreso")
                        .HasColumnType("datetime2");

                    b.Property<string>("MarcaMotocicleta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("MotocicletaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PlacaMotocicleta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TallerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TallerId");

                    b.ToTable("Motocicletas");
                });

            modelBuilder.Entity("SistemaMotocicletas.Models.Taller", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DireccionTaller")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreTaller")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZonaTaller")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Talleres");
                });

            modelBuilder.Entity("SistemaMotocicletas.Models.Motocicleta", b =>
                {
                    b.HasOne("SistemaMotocicletas.Models.Taller", "Taller")
                        .WithMany("Motocicletas")
                        .HasForeignKey("TallerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Taller");
                });

            modelBuilder.Entity("SistemaMotocicletas.Models.Taller", b =>
                {
                    b.Navigation("Motocicletas");
                });
#pragma warning restore 612, 618
        }
    }
}
