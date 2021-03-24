using arquiteturaLimpa.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace arquiteturaLimpa.Core.Interface
{
    public interface IUsuarioService
    {
        public Usuario UsuarioFindByEmailAndPassword(string Email, string password);

        public Usuario Logoff();

        public string SendEmail(String Email);
    }
}
