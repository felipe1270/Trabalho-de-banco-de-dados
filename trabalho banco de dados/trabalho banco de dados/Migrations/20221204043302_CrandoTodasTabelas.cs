using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace trabalhobancodedados.Migrations
{
    /// <inheritdoc />
    public partial class CrandoTodasTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contatos");

            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    CursoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    departamento = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.CursoId);
                });

            migrationBuilder.CreateTable(
                name: "Examinador",
                columns: table => new
                {
                    ExaminadorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examinador", x => x.ExaminadorId);
                });

            migrationBuilder.CreateTable(
                name: "Grupo",
                columns: table => new
                {
                    GrupoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tema = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupo", x => x.GrupoId);
                });

            migrationBuilder.CreateTable(
                name: "TCC",
                columns: table => new
                {
                    TCCId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VesaoEntrega = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nota = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TCC", x => x.TCCId);
                });

            migrationBuilder.CreateTable(
                name: "Aluno",
                columns: table => new
                {
                    AlunoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TCCId = table.Column<int>(type: "int", nullable: false),
                    GrupoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluno", x => x.AlunoId);
                    table.ForeignKey(
                        name: "FK_Aluno_Grupo_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupo",
                        principalColumn: "GrupoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Aluno_TCC_TCCId",
                        column: x => x.TCCId,
                        principalTable: "TCC",
                        principalColumn: "TCCId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RelacionamentoExaminadorTCC",
                columns: table => new
                {
                    RelacionamentoExaminadorTCCId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TCCId = table.Column<int>(type: "int", nullable: false),
                    ExaminadorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelacionamentoExaminadorTCC", x => x.RelacionamentoExaminadorTCCId);
                    table.ForeignKey(
                        name: "FK_RelacionamentoExaminadorTCC_Examinador_ExaminadorId",
                        column: x => x.ExaminadorId,
                        principalTable: "Examinador",
                        principalColumn: "ExaminadorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RelacionamentoExaminadorTCC_TCC_TCCId",
                        column: x => x.TCCId,
                        principalTable: "TCC",
                        principalColumn: "TCCId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Professor",
                columns: table => new
                {
                    ProfessorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AlunoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professor", x => x.ProfessorId);
                    table.ForeignKey(
                        name: "FK_Professor_Aluno_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Aluno",
                        principalColumn: "AlunoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tema",
                columns: table => new
                {
                    TemaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlunoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tema", x => x.TemaId);
                    table.ForeignKey(
                        name: "FK_Tema_Aluno_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Aluno",
                        principalColumn: "AlunoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AreaPesquisa",
                columns: table => new
                {
                    AreaPesquisaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TemaId = table.Column<int>(type: "int", nullable: false),
                    ProfessorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaPesquisa", x => x.AreaPesquisaId);
                    table.ForeignKey(
                        name: "FK_AreaPesquisa_Professor_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professor",
                        principalColumn: "ProfessorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AreaPesquisa_Tema_TemaId",
                        column: x => x.TemaId,
                        principalTable: "Tema",
                        principalColumn: "TemaId",
                        onDelete: ReferentialAction.NoAction);
                        
                });

            migrationBuilder.CreateTable(
                name: "RelacionametoTemaTCC",
                columns: table => new
                {
                    RelacionametoTemaTCCId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TCCId = table.Column<int>(type: "int", nullable: false),
                    TemaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelacionametoTemaTCC", x => x.RelacionametoTemaTCCId);
                    table.ForeignKey(
                        name: "FK_RelacionametoTemaTCC_TCC_TCCId",
                        column: x => x.TCCId,
                        principalTable: "TCC",
                        principalColumn: "TCCId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RelacionametoTemaTCC_Tema_TemaId",
                        column: x => x.TemaId,
                        principalTable: "Tema",
                        principalColumn: "TemaId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "RelacionamentoCursoAreaPesquisa",
                columns: table => new
                {
                    RelacionamentoCursoAreaPesquisaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CursoId = table.Column<int>(type: "int", nullable: false),
                    AreaPesquisaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelacionamentoCursoAreaPesquisa", x => x.RelacionamentoCursoAreaPesquisaId);
                    table.ForeignKey(
                        name: "FK_RelacionamentoCursoAreaPesquisa_AreaPesquisa_AreaPesquisaId",
                        column: x => x.AreaPesquisaId,
                        principalTable: "AreaPesquisa",
                        principalColumn: "AreaPesquisaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RelacionamentoCursoAreaPesquisa_Curso_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Curso",
                        principalColumn: "CursoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aluno_GrupoId",
                table: "Aluno",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_Aluno_TCCId",
                table: "Aluno",
                column: "TCCId");

            migrationBuilder.CreateIndex(
                name: "IX_AreaPesquisa_ProfessorId",
                table: "AreaPesquisa",
                column: "ProfessorId");

            migrationBuilder.CreateIndex(
                name: "IX_AreaPesquisa_TemaId",
                table: "AreaPesquisa",
                column: "TemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Professor_AlunoId",
                table: "Professor",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_RelacionamentoCursoAreaPesquisa_AreaPesquisaId",
                table: "RelacionamentoCursoAreaPesquisa",
                column: "AreaPesquisaId");

            migrationBuilder.CreateIndex(
                name: "IX_RelacionamentoCursoAreaPesquisa_CursoId",
                table: "RelacionamentoCursoAreaPesquisa",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_RelacionamentoExaminadorTCC_ExaminadorId",
                table: "RelacionamentoExaminadorTCC",
                column: "ExaminadorId");

            migrationBuilder.CreateIndex(
                name: "IX_RelacionamentoExaminadorTCC_TCCId",
                table: "RelacionamentoExaminadorTCC",
                column: "TCCId");

            migrationBuilder.CreateIndex(
                name: "IX_RelacionametoTemaTCC_TCCId",
                table: "RelacionametoTemaTCC",
                column: "TCCId");

            migrationBuilder.CreateIndex(
                name: "IX_RelacionametoTemaTCC_TemaId",
                table: "RelacionametoTemaTCC",
                column: "TemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Tema_AlunoId",
                table: "Tema",
                column: "AlunoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RelacionamentoCursoAreaPesquisa");

            migrationBuilder.DropTable(
                name: "RelacionamentoExaminadorTCC");

            migrationBuilder.DropTable(
                name: "RelacionametoTemaTCC");

            migrationBuilder.DropTable(
                name: "AreaPesquisa");

            migrationBuilder.DropTable(
                name: "Curso");

            migrationBuilder.DropTable(
                name: "Examinador");

            migrationBuilder.DropTable(
                name: "Professor");

            migrationBuilder.DropTable(
                name: "Tema");

            migrationBuilder.DropTable(
                name: "Aluno");

            migrationBuilder.DropTable(
                name: "Grupo");

            migrationBuilder.DropTable(
                name: "TCC");

            migrationBuilder.CreateTable(
                name: "Contatos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatos", x => x.Id);
                });
        }
    }
}
