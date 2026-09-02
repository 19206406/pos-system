using FastEndpoints;

namespace Identity.Api.Users.LoginUser
{
    public record LoginUserRequest();

    public record LoginUserResponse(); 

    public class LoginUserEndpoint : Endpoint<LoginUserRequest, LoginUserResponse>
    {
        public override void Configure()
        {
            base.Configure();
        }

        public override Task HandleAsync(LoginUserRequest req, CancellationToken ct)
        {
            return base.HandleAsync(req, ct);
        }
    }
}
