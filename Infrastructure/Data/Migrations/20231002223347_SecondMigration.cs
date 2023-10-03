using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ciudades_Departamentos_DepartamentosId",
                table: "Ciudades");

            migrationBuilder.DropForeignKey(
                name: "FK_Departamentos_Paises_PaisesId",
                table: "Departamentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Paises",
                table: "Paises");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departamentos",
                table: "Departamentos");

            migrationBuilder.DropIndex(
                name: "IX_Departamentos_PaisesId",
                table: "Departamentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ciudades",
                table: "Ciudades");

            migrationBuilder.DropIndex(
                name: "IX_Ciudades_DepartamentosId",
                table: "Ciudades");

            migrationBuilder.DropColumn(
                name: "PaisesId",
                table: "Departamentos");

            migrationBuilder.DropColumn(
                name: "DepartamentosId",
                table: "Ciudades");

            migrationBuilder.RenameTable(
                name: "Paises",
                newName: "pais");

            migrationBuilder.RenameTable(
                name: "Departamentos",
                newName: "departamento");

            migrationBuilder.RenameTable(
                name: "Ciudades",
                newName: "ciudad");

            migrationBuilder.UpdateData(
                table: "pais",
                keyColumn: "Nombre",
                keyValue: null,
                column: "Nombre",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "pais",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "departamento",
                keyColumn: "Nombre",
                keyValue: null,
                column: "Nombre",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "departamento",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "ciudad",
                keyColumn: "Nombre",
                keyValue: null,
                column: "Nombre",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "ciudad",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pais",
                table: "pais",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_departamento",
                table: "departamento",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ciudad",
                table: "ciudad",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_departamento_IdPaisFk",
                table: "departamento",
                column: "IdPaisFk");

            migrationBuilder.CreateIndex(
                name: "IX_ciudad_IdDepartamentoFk",
                table: "ciudad",
                column: "IdDepartamentoFk");

            migrationBuilder.AddForeignKey(
                name: "FK_ciudad_departamento_IdDepartamentoFk",
                table: "ciudad",
                column: "IdDepartamentoFk",
                principalTable: "departamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_departamento_pais_IdPaisFk",
                table: "departamento",
                column: "IdPaisFk",
                principalTable: "pais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ciudad_departamento_IdDepartamentoFk",
                table: "ciudad");

            migrationBuilder.DropForeignKey(
                name: "FK_departamento_pais_IdPaisFk",
                table: "departamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pais",
                table: "pais");

            migrationBuilder.DropPrimaryKey(
                name: "PK_departamento",
                table: "departamento");

            migrationBuilder.DropIndex(
                name: "IX_departamento_IdPaisFk",
                table: "departamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ciudad",
                table: "ciudad");

            migrationBuilder.DropIndex(
                name: "IX_ciudad_IdDepartamentoFk",
                table: "ciudad");

            migrationBuilder.RenameTable(
                name: "pais",
                newName: "Paises");

            migrationBuilder.RenameTable(
                name: "departamento",
                newName: "Departamentos");

            migrationBuilder.RenameTable(
                name: "ciudad",
                newName: "Ciudades");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Paises",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Departamentos",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "PaisesId",
                table: "Departamentos",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Ciudades",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "DepartamentosId",
                table: "Ciudades",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Paises",
                table: "Paises",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departamentos",
                table: "Departamentos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ciudades",
                table: "Ciudades",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Departamentos_PaisesId",
                table: "Departamentos",
                column: "PaisesId");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudades_DepartamentosId",
                table: "Ciudades",
                column: "DepartamentosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ciudades_Departamentos_DepartamentosId",
                table: "Ciudades",
                column: "DepartamentosId",
                principalTable: "Departamentos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Departamentos_Paises_PaisesId",
                table: "Departamentos",
                column: "PaisesId",
                principalTable: "Paises",
                principalColumn: "Id");
        }
    }
}
