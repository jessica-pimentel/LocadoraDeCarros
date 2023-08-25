using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 2 - Domain.Interfaces
{
    public class ICarroRepository
    {
        Task<Carro> GetByIdAsync(int id);
        Task AddAsync(Carro carro);

        // falta adicionar outros métodos de consulta e modificação
    }
}