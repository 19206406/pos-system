using FastEndpoints;

namespace Identity.Api.Users.LoginUser
{
    public record LoginUserCommand();

    public class LoginUserHandler : ICommandHandler<LoginUserCommand, LoginUserResponse>
    {
        public Task<LoginUserResponse> ExecuteAsync(LoginUserCommand command, CancellationToken ct)
        {
            throw new NotImplementedException();
        }
    }
}
