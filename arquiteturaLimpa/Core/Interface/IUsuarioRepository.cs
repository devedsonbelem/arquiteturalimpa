using arquiteturaLimpa.Core.Entity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace arquiteturaLimpa.Core.Interface
{
    public interface IUsuarioRepository
    {
       public   Task<int> Add(Usuario usuario);
       public   Task<List<Usuario>>  FindAll();
       public   Task<Usuario>   FindById(int id);
    }
}

