using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 1 - Application.Services
{
    public class AluguelService : IAluguelService
{
    private readonly IAluguelRepository _aluguelRepository;
    private readonly ICarroRepository _carroRepository;
    private readonly IUsuarioRepository _usuarioRepository;

    public AluguelService(IAluguelRepository aluguelRepository, ICarroRepository carroRepository, IUsuarioRepository usuarioRepository)
    {
        _aluguelRepository = aluguelRepository;
        _carroRepository = carroRepository;
        _usuarioRepository = usuarioRepository;
    }

    public async Task AlugarCarroAsync(int carroId, int usuarioId, PeríodoAluguel período)
    {
        // Qual vai ser a lógica para o aluguel????
    }

}

}