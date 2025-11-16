namespace VitrineCupcakesMVC.Models
{
    public class ItemPedidoViewModel
    {
        public int Id { get; set; }

        public CupcakeViewModel Cupcake { get; set; }
        public int Quantidade { get; set; }
        public decimal Subtotal { get; set; }

    }
}
