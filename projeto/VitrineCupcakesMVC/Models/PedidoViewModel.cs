using VitrineCupcakesMVC.Models.Enum;

namespace VitrineCupcakesMVC.Models
{
    public class PedidoViewModel
    {
        public int Id { get; set; }

        public ClienteViewModel Cliente { get; set; }
        public List<CupcakeViewModel> Itens { get; set; } = new List<CupcakeViewModel>();

        public decimal Total { get; set; }
        public StatusPedido Status { get; set; }

        public MetodoPagamento MetodoPagamento { get; set; }
        public EnderecoViewModel EnderecoEntrega { get; set; }

        public DateTime DataCriacao { get; set; }
    }
}
