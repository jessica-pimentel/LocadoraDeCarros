using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 1 - Application.Interfaces
{
    public class ICarroService
    {
        Task<IEnumerable<Carro>> ListarCarrosDisponiveisAsync();
        // Outros métodos de serviço 
    }
}