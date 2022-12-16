﻿// <auto-generated />
using E2AFlix.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace E2AFlix.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("E2AFlix.Models.Filmes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Descricao");

                    b.Property<string>("Diretora")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Diretora");

                    b.Property<int>("FotoFilme")
                        .HasColumnType("int")
                        .HasColumnName("FotoFilme");

                    b.Property<bool>("JaAssistiu")
                        .HasColumnType("bit")
                        .HasColumnName("JaAssistiu");

                    b.Property<int>("Nota")
                        .HasColumnType("int")
                        .HasColumnName("Nota");

                    b.Property<string>("Produtora")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Produtora");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Titulo");

                    b.HasKey("Id");

                    b.ToTable("Filmes");
                });

            modelBuilder.Entity("E2AFlix.Models.Livros", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Descricao");

                    b.Property<int>("FotoLivro")
                        .HasColumnType("int")
                        .HasColumnName("FotoLivro");

                    b.Property<int>("Nota")
                        .HasColumnType("int")
                        .HasColumnName("Nota");

                    b.HasKey("Id");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("E2AFlix.Models.Musicas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Artista")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Artista");

                    b.Property<int>("FotoMusica")
                        .HasColumnType("int")
                        .HasColumnName("FotoMusica");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nome");

                    b.Property<int>("Nota")
                        .HasColumnType("int")
                        .HasColumnName("Nota");

                    b.HasKey("Id");

                    b.ToTable("Musicas");
                });
#pragma warning restore 612, 618
        }
    }
}