using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce.Migrations
{
    /// <inheritdoc />
    public partial class ecommerce_bd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pedido",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descricao = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    valor = table.Column<float>(type: "real", maxLength: 50, nullable: false),
                    totalgeral = table.Column<float>(type: "real", maxLength: 50, nullable: false),
                    tipopedido = table.Column<int>(type: "integer", nullable: false),
                    tipofrete = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedido", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "pedido",
                columns: new[] { "id", "descricao", "tipofrete", "tipopedido", "totalgeral", "valor" },
                values: new object[,]
                {
                    { 1, "Camisa Real Madrid", 2, 1, 2.5f, 20.5f },
                    { 2, "Camisa Barcelona", 2, 1, 25.5f, 50.5f },
                    { 3, "Camisa Corinthians", 2, 1, 25.5f, 100f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pedido");
        }
    }
}
