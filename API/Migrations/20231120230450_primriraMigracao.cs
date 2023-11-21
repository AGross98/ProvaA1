﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class primriraMigracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Status = table.Column<bool>(type: "INTEGER", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Tarefas",
                columns: table => new
                {
                    TarefaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(type: "TEXT", nullable: true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Status = table.Column<bool>(type: "INTEGER", nullable: false),
                    CategoriaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarefas", x => x.TarefaId);
                    table.ForeignKey(
                        name: "FK_Tarefas_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "CriadoEm", "Nome", "Status" },
                values: new object[] { 1, new DateTime(2023, 11, 21, 20, 4, 49, 879, DateTimeKind.Local).AddTicks(5725), "Trabalho", false });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "CriadoEm", "Nome", "Status" },
                values: new object[] { 2, new DateTime(2023, 11, 22, 20, 4, 49, 879, DateTimeKind.Local).AddTicks(5737), "Estudos", false });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "CriadoEm", "Nome", "Status" },
                values: new object[] { 3, new DateTime(2023, 11, 23, 20, 4, 49, 879, DateTimeKind.Local).AddTicks(5741), "Lazer", false });

            migrationBuilder.InsertData(
                table: "Tarefas",
                columns: new[] { "TarefaId", "CategoriaId", "CriadoEm", "Descricao", "Status", "Titulo" },
                values: new object[] { 1, 1, new DateTime(2023, 11, 27, 20, 4, 49, 879, DateTimeKind.Local).AddTicks(6005), "Terminar relatório para reunião", false, "Concluir relatório" });

            migrationBuilder.InsertData(
                table: "Tarefas",
                columns: new[] { "TarefaId", "CategoriaId", "CriadoEm", "Descricao", "Status", "Titulo" },
                values: new object[] { 2, 2, new DateTime(2023, 11, 23, 20, 4, 49, 879, DateTimeKind.Local).AddTicks(6010), "Preparar-se para a aula de Angular", false, "Estudar Angular" });

            migrationBuilder.InsertData(
                table: "Tarefas",
                columns: new[] { "TarefaId", "CategoriaId", "CriadoEm", "Descricao", "Status", "Titulo" },
                values: new object[] { 3, 3, new DateTime(2023, 12, 4, 20, 4, 49, 879, DateTimeKind.Local).AddTicks(6014), "Dar um passeio relaxante no parque", false, "Passeio no parque" });

            migrationBuilder.CreateIndex(
                name: "IX_Tarefas_CategoriaId",
                table: "Tarefas",
                column: "CategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarefas");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
