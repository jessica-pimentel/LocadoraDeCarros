using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 2 - Domain.Interfaces
{
    public class IUsuarioRepository
    {
        Task<Usuario> GetByIdAsync(int id);
        Task AddAsync(Usuario usuario);

        // falta adicionar outros métodos de consulta e modificação
    }
}