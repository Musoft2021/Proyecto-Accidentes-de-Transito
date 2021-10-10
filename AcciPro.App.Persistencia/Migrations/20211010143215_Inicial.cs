using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AcciPro.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventoAccidentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_persona = table.Column<int>(type: "int", nullable: false),
                    id_agente = table.Column<int>(type: "int", nullable: false),
                    id_vehiculo = table.Column<int>(type: "int", nullable: false),
                    Id_accidente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventoAccidentes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cedula = table.Column<int>(type: "int", nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    edad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccidenteId = table.Column<int>(type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitud = table.Column<float>(type: "real", nullable: true),
                    Longitud = table.Column<float>(type: "real", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Accidentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Latitud = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longitud = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgenteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accidentes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accidentes_Personas_AgenteId",
                        column: x => x.AgenteId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TipoVehiculos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo_Propietario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Matricula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccidenteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoVehiculos", x => x.id);
                    table.ForeignKey(
                        name: "FK_TipoVehiculos_Accidentes_AccidenteId",
                        column: x => x.AccidenteId,
                        principalTable: "Accidentes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accidentes_AgenteId",
                table: "Accidentes",
                column: "AgenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_AccidenteId",
                table: "Personas",
                column: "AccidenteId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoVehiculos_AccidenteId",
                table: "TipoVehiculos",
                column: "AccidenteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Accidentes_AccidenteId",
                table: "Personas",
                column: "AccidenteId",
                principalTable: "Accidentes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accidentes_Personas_AgenteId",
                table: "Accidentes");

            migrationBuilder.DropTable(
                name: "EventoAccidentes");

            migrationBuilder.DropTable(
                name: "TipoVehiculos");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Accidentes");
        }
    }
}
