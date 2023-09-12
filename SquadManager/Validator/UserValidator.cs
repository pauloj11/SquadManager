using FluentValidation;
using SquadManager.Models;

namespace SquadManager.Validator
{
    public class UserValidator : AbstractValidator<UserViewModel>
    {
        public UserValidator() {
            RuleFor(user => user.Email).NotNull().WithMessage("E-mail não foi informado.");
            RuleFor(user => user.Email).EmailAddress().WithMessage("E-mail inválido. Corrija por favor");
            RuleFor(user => user.Password).NotNull().WithMessage("Senha não foi informada.");
        }
    }
}
