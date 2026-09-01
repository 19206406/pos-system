using FluentValidation;

namespace User.Api.Users.RegisterUser
{
    public class RegisterUserValidation : AbstractValidator<RegisterUserCommand>
    {
        public RegisterUserValidation()
        {
            RuleFor(x => x.FullName)
                .NotEmpty().WithMessage("El nombre del nuevo usuario no puede ser vacío.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("El email del nuevo usuario no puede ser vacío.");

            RuleFor(x => x.PhoneNumber)
                .NotEmpty().WithMessage("El telefono del usuario debe de contener un valor.");

            RuleFor(x => x.Position)
                .NotEmpty().WithMessage("El usuario debe de contener un cargo dentro de la organización."); 
        }
    }
}
