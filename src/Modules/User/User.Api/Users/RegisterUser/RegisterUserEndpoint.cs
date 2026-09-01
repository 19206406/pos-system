using FastEndpoints;

namespace User.Api.Users.RegisterUser
{
    public record RegisterUserRequest(string FullName, string PhoneNumber, string Position, string Email);
    public record RegisterUserResponse(string Id);

    public class RegisterUserEndpoint : Endpoint<RegisterUserRequest, RegisterUserResponse>
    {
        public override void Configure()
        {
            Post("api/users");
            // TODO: Only people with a specific role and permission can perform this action. 
        }

        public override async Task HandleAsync(RegisterUserRequest req, CancellationToken ct)
        {
            var newUser = await new RegisterUserCommand(req.FullName, req.PhoneNumber, req.Position, req.Email).ExecuteAsync();

            await Send.OkAsync(newUser); 
        }
    }
}
