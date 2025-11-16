using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VitrineCupcakesAPI.Configuration;
using VitrineCupcakesAPI.Entities;

namespace VitrineCupcakesAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VitrineController : ControllerBase
{

    private readonly ApplicationDbContext _context;

    public VitrineController(ApplicationDbContext context)
    {
        _context = context;
    }

    // POST api/pedidos
    [HttpPost]
    public IActionResult CriarPedido([FromBody] Pedido pedido)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        _context.Pedidos.Add(pedido);
        _context.SaveChanges();

        return CreatedAtAction(nameof(ObterPedido), new { id = pedido.Id }, pedido);
    }

    // GET api/pedidos
    [HttpGet]
    public IActionResult ListarPedidos()
    {
        var pedidos = _context.Pedidos
            .Include(p => p.Itens)
            .ToList();

        return Ok(pedidos);
    }

    // GET api/pedidos/{id}
    [HttpGet("{id}")]
    public IActionResult ObterPedido(int id)
    {
        var pedido = _context.Pedidos
            .Include(p => p.Itens)
            .FirstOrDefault(p => p.Id == id);

        if (pedido == null)
            return NotFound();

        return Ok(pedido);
    }
}
