using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 1 - Application.Handlers
{
    public class AlugarCarroCommandHandler : IRequestHandler<AlugarCarroCommand>
{
    private readonly IAluguelService _aluguelService;

    public AlugarCarroCommandHandler(IAluguelService aluguelService)
    {
        _aluguelService = aluguelService;
    }

    public async Task<Unit> Handle(AlugarCarroCommand request, CancellationToken cancellationToken)
    {
        await _aluguelService.AlugarCarroAsync(request.CarroId, request.UsuarioId, request.Periodo);
        return Unit.Value;
    }
}
    // Implementar outros manipuladores semelhantes para outros comandos e consultas...
}