using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CerezoJose_Progreso1.Migrations
{
    /// <inheritdoc />
    public partial class Telefonoañadidoausuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TelefonoId",
                table: "JoseCerezo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Telefono",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Anio = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefono", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JoseCerezo_TelefonoId",
                table: "JoseCerezo",
                column: "TelefonoId");

            migrationBuilder.AddForeignKey(
                name: "FK_JoseCerezo_Telefono_TelefonoId",
                table: "JoseCerezo",
                column: "TelefonoId",
                principalTable: "Telefono",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JoseCerezo_Telefono_TelefonoId",
                table: "JoseCerezo");

            migrationBuilder.DropTable(
                name: "Telefono");

            migrationBuilder.DropIndex(
                name: "IX_JoseCerezo_TelefonoId",
                table: "JoseCerezo");

            migrationBuilder.DropColumn(
                name: "TelefonoId",
                table: "JoseCerezo");
        }
    }
}
