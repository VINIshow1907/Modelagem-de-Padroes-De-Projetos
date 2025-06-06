﻿// <auto-generated />
using Ecommerce.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Ecommerce.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250523005100_ecommerce_bd")]
    partial class ecommerce_bd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Ecommerce.Objects.Models.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("descricao");

                    b.Property<int>("FreteType")
                        .HasColumnType("integer")
                        .HasColumnName("tipofrete");

                    b.Property<int>("PedidoType")
                        .HasColumnType("integer")
                        .HasColumnName("tipopedido");

                    b.Property<float>("TotalGeral")
                        .HasMaxLength(50)
                        .HasColumnType("real")
                        .HasColumnName("totalgeral");

                    b.Property<float>("Valor")
                        .HasMaxLength(50)
                        .HasColumnType("real")
                        .HasColumnName("valor");

                    b.HasKey("Id");

                    b.ToTable("pedido");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "Camisa Real Madrid",
                            FreteType = 2,
                            PedidoType = 1,
                            TotalGeral = 2.5f,
                            Valor = 20.5f
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "Camisa Barcelona",
                            FreteType = 2,
                            PedidoType = 1,
                            TotalGeral = 25.5f,
                            Valor = 50.5f
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "Camisa Corinthians",
                            FreteType = 2,
                            PedidoType = 1,
                            TotalGeral = 25.5f,
                            Valor = 100f
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
