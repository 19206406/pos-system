using FastEndpoints;

namespace Identity.Api.Users.LoginUser
{
    public record LoginUserCommand(string Email, string Password) : ICommand<LoginUserResponse>;

    public class LoginUserHandler : ICommandHandler<LoginUserCommand, LoginUserResponse>
    {
        public async Task<LoginUserResponse> ExecuteAsync(LoginUserCommand command, CancellationToken ct)
        {



            return new LoginUserResponse(true); 
        }
    }
}
