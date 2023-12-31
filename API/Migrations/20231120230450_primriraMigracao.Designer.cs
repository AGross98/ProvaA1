﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(AppDataContext))]
    [Migration("20231120230450_primriraMigracao")]
    partial class primriraMigracao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<bool>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            CategoriaId = 1,
                            CriadoEm = new DateTime(2023, 11, 21, 20, 4, 49, 879, DateTimeKind.Local).AddTicks(5725),
                            Nome = "Trabalho",
                            Status = false
                        },
                        new
                        {
                            CategoriaId = 2,
                            CriadoEm = new DateTime(2023, 11, 22, 20, 4, 49, 879, DateTimeKind.Local).AddTicks(5737),
                            Nome = "Estudos",
                            Status = false
                        },
                        new
                        {
                            CategoriaId = 3,
                            CriadoEm = new DateTime(2023, 11, 23, 20, 4, 49, 879, DateTimeKind.Local).AddTicks(5741),
                            Nome = "Lazer",
                            Status = false
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
                            CriadoEm = new DateTime(2023, 11, 27, 20, 4, 49, 879, DateTimeKind.Local).AddTicks(6005),
                            Descricao = "Terminar relatório para reunião",
                            Status = false,
                            Titulo = "Concluir relatório"
                        },
                        new
                        {
                            TarefaId = 2,
                            CategoriaId = 2,
                            CriadoEm = new DateTime(2023, 11, 23, 20, 4, 49, 879, DateTimeKind.Local).AddTicks(6010),
                            Descricao = "Preparar-se para a aula de Angular",
                            Status = false,
                            Titulo = "Estudar Angular"
                        },
                        new
                        {
                            TarefaId = 3,
                            CategoriaId = 3,
                            CriadoEm = new DateTime(2023, 12, 4, 20, 4, 49, 879, DateTimeKind.Local).AddTicks(6014),
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
