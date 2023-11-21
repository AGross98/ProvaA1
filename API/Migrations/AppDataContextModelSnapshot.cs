﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(AppDataContext))]
    partial class AppDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.25");

            modelBuilder.Entity("API.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            CategoriaId = 1,
                            CriadoEm = new DateTime(2023, 11, 21, 20, 46, 4, 82, DateTimeKind.Local).AddTicks(4548),
                            Nome = "Trabalho"
                        },
                        new
                        {
                            CategoriaId = 2,
                            CriadoEm = new DateTime(2023, 11, 22, 20, 46, 4, 82, DateTimeKind.Local).AddTicks(4558),
                            Nome = "Estudos"
                        },
                        new
                        {
                            CategoriaId = 3,
                            CriadoEm = new DateTime(2023, 11, 23, 20, 46, 4, 82, DateTimeKind.Local).AddTicks(4559),
                            Nome = "Lazer"
                        });
                });

            modelBuilder.Entity("API.Models.Tarefa", b =>
                {
                    b.Property<int>("TarefaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Titulo")
                        .HasColumnType("TEXT");

                    b.HasKey("TarefaId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Tarefas");

                    b.HasData(
                        new
                        {
                            TarefaId = 1,
                            CategoriaId = 1,
                            CriadoEm = new DateTime(2023, 11, 27, 20, 46, 4, 82, DateTimeKind.Local).AddTicks(4650),
                            Descricao = "Terminar relatório para reunião",
                            Status = false,
                            Titulo = "Concluir relatório"
                        },
                        new
                        {
                            TarefaId = 2,
                            CategoriaId = 2,
                            CriadoEm = new DateTime(2023, 11, 23, 20, 46, 4, 82, DateTimeKind.Local).AddTicks(4651),
                            Descricao = "Preparar-se para a aula de Angular",
                            Status = false,
                            Titulo = "Estudar Angular"
                        },
                        new
                        {
                            TarefaId = 3,
                            CategoriaId = 3,
                            CriadoEm = new DateTime(2023, 12, 4, 20, 46, 4, 82, DateTimeKind.Local).AddTicks(4653),
                            Descricao = "Dar um passeio relaxante no parque",
                            Status = false,
                            Titulo = "Passeio no parque"
                        });
                });

            modelBuilder.Entity("API.Models.Tarefa", b =>
                {
                    b.HasOne("API.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });
#pragma warning restore 612, 618
        }
    }
}
