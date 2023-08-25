using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 1 - Application.Commands
{
 public class AlugarCarroCommand : ICommand
{
    public int CarroId { get; set; }
    public int UsuarioId { get; set; }
    public PeríodoAluguel Periodo { get; set; }
}

// Application/Queries/ListarCarrosQuery.cs
public class ListarCarrosQuery : IQuery<IEnumerable<CarroDto>>
{
}

// Implementar outras classes de comandos e consultas semelhantes...

}