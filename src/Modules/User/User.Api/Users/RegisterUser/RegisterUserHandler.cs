using FastEndpoints;

namespace User.Api.Users.RegisterUser
{
    public record RegisterUserCommand(string FullName, string Email, string PhoneNumber, string Position) 
        : ICommand<RegisterUserResponse>;

    public class RegisterUserHandler : ICommandHandler<RegisterUserCommand, RegisterUserResponse>
    {
        public async Task<RegisterUserResponse> ExecuteAsync(RegisterUserCommand command, CancellationToken ct)
        {
            // TODO: Implement the validation pipeline using FluentValidation
            return new RegisterUserResponse("1122333"); 
        }
    }
}
