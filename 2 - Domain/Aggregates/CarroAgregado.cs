using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 2 - Domain.Aggregates
{
    public class CarroAgregado
    {
        private readonly Carro _carro;
        private readonly List<Aluguel> _aluguel;

        public CarroAgregado(Carro carro)
        {
            _carro = carro;
            _aluguel = new List<Aluguel>();
        }

        //criar aqui métodos para alugar o carro, verificar disponibilidade, mudar status
    }
}