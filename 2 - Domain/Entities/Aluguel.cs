using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 2 - Domain.Entities
{
    public class Aluguel
    {
        public int Id { get; set; }
        public int CarroId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; } 
    }
}