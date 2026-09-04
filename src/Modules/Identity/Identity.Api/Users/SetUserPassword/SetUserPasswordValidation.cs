using FluentValidation;

namespace Identity.Api.Users.SetUserPassword
{
    public class SetUserPasswordValidation : AbstractValidator<SetUserPasswordCommmand>
    {
        public SetUserPasswordValidation()
        {
            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("The password cannot be empty.")
                .MinimumLength(4).WithMessage("The password must be at least 4 characters long.");

            //! This probably shouldn't be here. 
            RuleFor(x => x.VerificationPassword)
                .NotEmpty().WithMessage("The password confirmation cannot be left blank.");

            RuleFor(x => x.Password)
                .Equal(x => x.VerificationPassword).WithMessage("The password does not match the confirmation password"); 
        }
    }
}
