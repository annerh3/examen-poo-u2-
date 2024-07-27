using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoExamenU2POO.Migrations
{
    /// <inheritdoc />
    public partial class DBinit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "pago",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    num_cuota = table.Column<int>(type: "int", nullable: false),
                    fecha_pago = table.Column<DateOnly>(type: "date", nullable: false),
                    interes = table.Column<double>(type: "float", nullable: false),
                    principal = table.Column<double>(type: "float", nullable: false),
                    cuota_sin_svsd = table.Column<double>(type: "float", nullable: false),
                    cuota_con_svsd = table.Column<double>(type: "float", nullable: false),
                    saldo_principal = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pago", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "prestamo",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    monto_prestamo = table.Column<int>(type: "int", nullable: false),
                    monto_comision = table.Column<int>(type: "int", nullable: false),
                    tasa_interes = table.Column<int>(type: "int", nullable: false),
                    plazo = table.Column<int>(type: "int", nullable: false),
                    fecha_desembolso = table.Column<DateOnly>(type: "date", nullable: false),
                    fecha_primer_pago = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prestamo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "prestamo_pago",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    prestamo_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    pago_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prestamo_pago", x => x.id);
                    table.ForeignKey(
                        name: "FK_prestamo_pago_pago_pago_id",
                        column: x => x.pago_id,
                        principalSchema: "dbo",
                        principalTable: "pago",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_prestamo_pago_prestamo_prestamo_id",
                        column: x => x.prestamo_id,
                        principalSchema: "dbo",
                        principalTable: "prestamo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_prestamo_pago_pago_id",
                schema: "dbo",
                table: "prestamo_pago",
                column: "pago_id");

            migrationBuilder.CreateIndex(
                name: "IX_prestamo_pago_prestamo_id",
                schema: "dbo",
                table: "prestamo_pago",
                column: "prestamo_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "prestamo_pago",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "pago",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "prestamo",
                schema: "dbo");
        }
    }
}
