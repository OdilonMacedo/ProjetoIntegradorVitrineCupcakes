using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VitrineCupcakesAPI.Configuration;
using VitrineCupcakesAPI.Entities;

namespace VitrineCupcakesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CupcakesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CupcakesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET api/cupcakes
        [HttpGet]
        public async Task<IActionResult> GetCupcakes()
        {
            var lista = await _context.Cupcakes.ToListAsync();
            return Ok(lista);
        }

        // GET api/cupcakes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCupcake(int id)
        {
            var cupcake = await _context.Cupcakes.FindAsync(id);

            if (cupcake == null)
                return NotFound();

            return Ok(cupcake);
        }

        // POST api/cupcakes
        [HttpPost]
        public async Task<IActionResult> AddCupcake([FromBody] Cupcake cupcake)
        {
            _context.Cupcakes.Add(cupcake);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetCupcake), new { id = cupcake.Id }, cupcake);
        }
    }
}
