using arquiteturaLimpa.Core.Entity;
using arquiteturaLimpa.Infra.Dbcontext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace arquiteturaLimpa.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly UsuarioContext _context;

        public UsuarioController(UsuarioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Usuario> GetUsuarios()
        {
            return _context.Usuarios.ToList();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUsuario([FromBody] Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();
            return Ok(usuario);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUsuarioById(int id)
        {
            var usuarios = await _context.Usuarios.FindAsync(id);
            if (usuarios == null)
            {
                return NotFound();
            }
            return usuarios;
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<Usuario>> DeleteUsuario(int id)
        {
            var usuarios = await _context.Usuarios.FindAsync(id);
            if (usuarios == null)
            {
                return NotFound();
            }
            _context.Usuarios.Remove(usuarios);
            await _context.SaveChangesAsync();
            return usuarios;
        }

        private bool UsuarioExiste(int id)
        {
            return _context.Usuarios.Any(e => e.Id == id);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Usuario usuarios)
        {
            if (id != usuarios.Id)
            {
                return BadRequest();
            }
            _context.Entry(usuarios).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioExiste(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }
    }
}
