namespace VitrineCupcakesMVC.Models
{
    public class CheckoutViewModel
    {
        public List<CupcakeViewModel> Itens { get; set; } = new();
        public decimal Total { get; set; }

        // Dados do cliente
        public string NomeCliente { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string MetodoPagamento { get; set; }
    }
}
