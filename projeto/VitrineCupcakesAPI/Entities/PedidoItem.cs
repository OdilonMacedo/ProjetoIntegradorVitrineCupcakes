namespace VitrineCupcakesAPI.Entities
{
    public class PedidoItem
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }

        public int CupcakeId { get; set; }
        public Cupcake Cupcake { get; set; }

        public decimal Preco { get; set; }
    }
}
