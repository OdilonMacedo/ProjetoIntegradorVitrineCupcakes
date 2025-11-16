namespace VitrineCupcakesAPI.Entities
{
    public class Cupcake
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public string Descricao { get; set; } = "";
        public decimal Preco { get; set; }
        public bool Disponivel { get; set; }
        public string ImagemUrl { get; set; } = "";
    }
}
