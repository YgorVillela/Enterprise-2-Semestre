﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _04_Fiap.Web.AspNet.Persistence;

namespace _04_Fiap.Web.AspNet.Migrations
{
    [DbContext(typeof(LocadoraContext))]
    partial class LocadoraContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_04_Fiap.Web.AspNet.Models.Veiculo", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("cd_codigo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Combustivel");

                    b.Property<DateTime>("DataFabricacao");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<float>("Peso");

                    b.HasKey("Codigo");

                    b.ToTable("T_VEICULO");
                });
#pragma warning restore 612, 618
        }
    }
}