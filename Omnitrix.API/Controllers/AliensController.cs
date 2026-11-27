using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Omnitrix.API.Data;
using Omnitrix.API.Models;

namespace Omnitrix.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AliensController : ControllerBase
    {
        private readonly OmnitrixDbContext _context;

        public AliensController(OmnitrixDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetAliens()
        {
            var aliens = await _context.Aliens.ToListAsync();
            return Ok(aliens);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAlien(Alien alien)
        {
            _context.Aliens.Add(alien);
            await _context.SaveChangesAsync();
            return Ok(alien);
        }
        [HttpGet("{id}")]
        
        public async Task<IActionResult> GetById(int id)
        {
            var alienid = await _context.Aliens.FindAsync(id);
            if (alienid == null) { return NotFound(); }
            return Ok(alienid);

        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAlien(int id, Alien alien)
        {
            var update = await _context.Aliens.FindAsync(id);
            if (update == null) { return NotFound(); }
            
            update.Nombre = alien.Nombre;
            update.Planeta = alien.Planeta;
            update.Especie = alien.Especie;
            update.Poder = alien.Poder;
            update.Fuerza = alien.Fuerza;
            update.Velocidad = alien.Velocidad;
            update.Disponible = alien.Disponible;

            await _context.SaveChangesAsync();
            return Ok(update);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlien(int id)
        {
            var delete = await _context.Aliens.FindAsync(id);
            if (delete == null) { return NotFound(); }
            _context.Aliens.Remove(delete);

            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
        
}
