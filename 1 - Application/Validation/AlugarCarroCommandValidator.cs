using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 1 - Application.Validation
{
 public class AlugarCarroCommandValidator : AbstractValidator<AlugarCarroCommand>
{
    public AlugarCarroCommandValidator()
    {
        RuleFor(command => command.CarroId).GreaterThan(0);
        RuleFor(command => command.UsuarioId).GreaterThan(0);
        // Outras regras de validação preciso pesquisar e entender
    }
}

// Implementar outros validadores semelhantes para outros commands???? por mais que não saída o que isso significa
}