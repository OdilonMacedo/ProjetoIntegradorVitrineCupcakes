using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using VitrineCupcakesAPI.Entities;

namespace VitrineCupcakesAPI.Configuration
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<Cupcake> Cupcakes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoItem> PedidoItens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cupcake>().HasData(
                new Cupcake { Id = 1, Nome = "Chocolate", Descricao = "Cobertura de brigadeiro gourmet.", Preco = 9.50m, Disponivel = true, ImagemUrl = "/img/chocolate.jpg" },
                new Cupcake { Id = 2, Nome = "Menta", Descricao = "Sabor inigualavel de menta.", Preco = 11.00m, Disponivel = true, ImagemUrl = "/img/menta.jpg" },
                new Cupcake { Id = 3, Nome = "Baunilha", Descricao = "Clássico americano com creme especial.", Preco = 12.50m, Disponivel = true, ImagemUrl = "/img/baunilha.jpg" },
                new Cupcake { Id = 4, Nome = "Cereja", Descricao = "Inspirado no floresta negra.", Preco = 10.50m, Disponivel = true, ImagemUrl = "/img/cereja.jpg" }
            );
        }
    }
}
