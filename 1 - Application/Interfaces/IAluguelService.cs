using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 1 - Application.Interfaces
{
    public class IAluguelService
    {
         Task AlugarCarroAsync(int carroId, int usuarioId, PeríodoAluguel período);
        // Outros métodos de serviço
    }
}