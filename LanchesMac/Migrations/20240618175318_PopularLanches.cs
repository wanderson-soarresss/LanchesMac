using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class PopularLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
         migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada," +
                "EmEstoque,ImagemUrl,ImageThumbnailUrl,IsLanchePreferido,Nome,Preco) " +
                "VALUES(2,'Pão, hambúrguer, ovo, alface','Delicioso pão de hambúrguer com ovo,',1, 'https://initiate.alphacoders.com/images/131/cropped-300-300-1313839.jpg?7153'," +
                "'https://initiate.alphacoders.com/images/131/cropped-300-300-1313839.jpg?7153',1 ,'cheese Salad', 10.50)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
