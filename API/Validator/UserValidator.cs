using Common;
using FluentValidation;

namespace API.Validator
{
    public class UserValidator : AbstractValidator<UserModel>
    {
        public UserValidator()
        {
            RuleFor(user => user.Username).NotNull().WithMessage("Usuário não foi informado.");
            RuleFor(user => user.Email).NotNull().WithMessage("E-mail não foi informado.");
            RuleFor(user => user.Email).EmailAddress().WithMessage("E-mail inválido. Corrija por favor");
            RuleFor(user => user.Password).NotNull().WithMessage("Senha não foi informada.");
            RuleFor(user => user.Password).Equal(o => o.ConfirmPassword).WithMessage("Campos de senha não coincidem.");
        }
    }
}