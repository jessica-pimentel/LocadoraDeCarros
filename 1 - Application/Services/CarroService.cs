using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 1 - Application.Services
{
    public class CarroService ICarroService
{
    private readonly ICarroRepository _carroRepository;

    public CarroService(ICarroRepository carroRepository)
    {
        _carroRepository = carroRepository;
    }

    public async Task<IEnumerable<Carro>> ListarCarrosDisponiveisAsync()
    {
        // Lógica para listar os carros disponíveis ainda para aluguel?
    }
}
}