using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VitrineCupcakesAPI.Migrations
{
    public partial class secondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cupcakes",
                columns: new[] { "Id", "Descricao", "Disponivel", "ImagemUrl", "Nome", "Preco" },
                values: new object[,]
                {
                    { 1, "Cobertura de brigadeiro gourmet.", true, "/img/chocolate.jpg", "Chocolate", 9.50m },
                    { 2, "Sabor inigualavel de menta.", true, "/img/menta.jpg", "Menta", 11.00m },
                    { 3, "Clássico americano com creme especial.", true, "/img/baunilha.jpg", "Baunilha", 12.50m },
                    { 4, "Inspirado no floresta negra.", true, "/img/cereja.jpg", "Cereja", 10.50m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cupcakes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cupcakes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cupcakes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cupcakes",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
