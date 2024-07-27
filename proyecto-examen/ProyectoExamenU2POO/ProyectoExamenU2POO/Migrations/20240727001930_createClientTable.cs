using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoExamenU2POO.Migrations
{
    /// <inheritdoc />
    public partial class createClientTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "clientes",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    monto_prestano = table.Column<int>(type: "int", nullable: false),
                    monto_comision = table.Column<int>(type: "int", nullable: false),
                    tasa_interes = table.Column<int>(type: "int", nullable: false),
                    plazo = table.Column<int>(type: "int", nullable: false),
                    fecha_desembolso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha_primer_pago = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clientes",
                schema: "dbo");
        }
    }
}
