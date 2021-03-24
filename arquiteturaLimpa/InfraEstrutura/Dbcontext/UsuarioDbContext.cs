using arquiteturaLimpa.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace arquiteturaLimpa.Infra.Dbcontext
{
    public class UsuarioContext : DbContext
    {

        public UsuarioContext(DbContextOptions<UsuarioContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { set; get; }

    }
}
