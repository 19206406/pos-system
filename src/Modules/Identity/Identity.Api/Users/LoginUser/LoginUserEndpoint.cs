using FastEndpoints;

namespace Identity.Api.Users.LoginUser
{
    public record LoginUserRequest(string Email, string Password);

    public record LoginUserResponse(bool Success); 

    public class LoginUserEndpoint : Endpoint<LoginUserRequest, LoginUserResponse>
    {
        public override void Configure()
        {
            Post("/api/login");
            AllowAnonymous(); 
        }

        public override async Task HandleAsync(LoginUserRequest req, CancellationToken ct)
        {
            var command = await new LoginUserCommand(req.Email, req.Password).ExecuteAsync(); 

            await Send.OkAsync(); 
        }
    }
}
