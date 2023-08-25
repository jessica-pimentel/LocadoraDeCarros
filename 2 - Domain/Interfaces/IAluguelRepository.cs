using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 2 - Domain.Interfaces
{
    public class IAluguelRepository
    {
        Task<Aluguel> GetByIdAsync(int id);
        Task AddAsync(Aluguel aluguel);
        // também falta adicionar outros métodos de consulta e modificação
    }
}