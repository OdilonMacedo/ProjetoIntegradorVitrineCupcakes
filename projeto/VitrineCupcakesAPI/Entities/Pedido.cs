namespace VitrineCupcakesAPI.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; } = "";
        public string Email { get; set; } = "";
        public string Endereco { get; set; } = "";
        public string Cidade { get; set; } = "";
        public string Cep { get; set; } = "";
        public string MetodoPagamento { get; set; } = "";
        public decimal Total { get; set; }

        public List<PedidoItem> Itens { get; set; } = new();
    }
}
