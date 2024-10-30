using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CerezoJose_Progreso1.Migrations
{
    /// <inheritdoc />
    public partial class Modeloscreados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JoseCerezo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CantidadHermanos = table.Column<int>(type: "int", nullable: false),
                    SaldoBancario = table.Column<double>(type: "float", nullable: false),
                    EsHombre = table.Column<bool>(type: "bit", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoseCerezo", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JoseCerezo");
        }
    }
}
