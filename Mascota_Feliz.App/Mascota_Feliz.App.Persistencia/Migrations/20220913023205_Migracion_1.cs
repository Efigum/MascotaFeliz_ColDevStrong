using Microsoft.EntityFrameworkCore.Migrations;

namespace Mascota_Feliz.App.Persistencia.Migrations
{
    public partial class Migracion_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "propietarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres_Propietario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos_Propietario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion_Propietario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono_Propietario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo_Electronico = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_propietarios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "veterinarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Veterinario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos_Veterinario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion_Veterinario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono_Veterinario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarjeta_Profesional = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_veterinarios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "mascotas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Mascota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Especie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Raza = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    propietarioid = table.Column<int>(type: "int", nullable: true),
                    medico_veterinarioid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mascotas", x => x.id);
                    table.ForeignKey(
                        name: "FK_mascotas_propietarios_propietarioid",
                        column: x => x.propietarioid,
                        principalTable: "propietarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_mascotas_veterinarios_medico_veterinarioid",
                        column: x => x.medico_veterinarioid,
                        principalTable: "veterinarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "historias_clinica",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mascotaid = table.Column<int>(type: "int", nullable: true),
                    Fecha_Apertura_HC = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_historias_clinica", x => x.id);
                    table.ForeignKey(
                        name: "FK_historias_clinica_mascotas_mascotaid",
                        column: x => x.mascotaid,
                        principalTable: "mascotas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "visitas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha_Visita = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Peso = table.Column<double>(type: "float", nullable: false),
                    Temperatura = table.Column<double>(type: "float", nullable: false),
                    Frecuencia_Cardiaca = table.Column<double>(type: "float", nullable: false),
                    Frecuencia_Respiratoria = table.Column<double>(type: "float", nullable: false),
                    Estado_de_animo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Recomendaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    historia_clinicaid = table.Column<int>(type: "int", nullable: true),
                    Medicamentos = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visitas", x => x.id);
                    table.ForeignKey(
                        name: "FK_visitas_historias_clinica_historia_clinicaid",
                        column: x => x.historia_clinicaid,
                        principalTable: "historias_clinica",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_historias_clinica_mascotaid",
                table: "historias_clinica",
                column: "mascotaid");

            migrationBuilder.CreateIndex(
                name: "IX_mascotas_medico_veterinarioid",
                table: "mascotas",
                column: "medico_veterinarioid");

            migrationBuilder.CreateIndex(
                name: "IX_mascotas_propietarioid",
                table: "mascotas",
                column: "propietarioid");

            migrationBuilder.CreateIndex(
                name: "IX_visitas_historia_clinicaid",
                table: "visitas",
                column: "historia_clinicaid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "visitas");

            migrationBuilder.DropTable(
                name: "historias_clinica");

            migrationBuilder.DropTable(
                name: "mascotas");

            migrationBuilder.DropTable(
                name: "propietarios");

            migrationBuilder.DropTable(
                name: "veterinarios");
        }
    }
}
