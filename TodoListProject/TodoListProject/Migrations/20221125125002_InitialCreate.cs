using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoListProject.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "todoTypeEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_todoTypeEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "todoList",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    done = table.Column<bool>(type: "INTEGER", nullable: false),
                    dueDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    description = table.Column<string>(type: "TEXT", nullable: true),
                    todoTypeId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_todoList", x => x.id);
                    table.ForeignKey(
                        name: "FK_todoList_todoTypeEntities_todoTypeId",
                        column: x => x.todoTypeId,
                        principalTable: "todoTypeEntities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_todoList_todoTypeId",
                table: "todoList",
                column: "todoTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "todoList");

            migrationBuilder.DropTable(
                name: "todoTypeEntities");
        }
    }
}
