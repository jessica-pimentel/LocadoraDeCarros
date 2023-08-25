using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 3 - Infrastructure.Repositories
{
public class CarroRepository : ICarroRepository
{
    private readonly DbContext _context;

    public CarroRepository(DbContext context)
    {
        _context = context;
    }

    public async Task<Carro> GetByIdAsync(int id)
    {
        return await _context.Set<Carro>().FindAsync(id);
    }

    public async Task AddAsync(Carro carro)
    {
        _context.Set<Carro>().Add(carro);
        await _context.SaveChangesAsync();
    }

    // Implementar outros métodos do repositório...
}

    // Implementar outros repositórios semelhantes para outras entidades...
}