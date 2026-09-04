using FastEndpoints;

namespace Identity.Api.Users.SetUserPassword
{
    public record SetUserPasswordRequest(string Password, string VerificationPassword);
    public record SetUserPasswordResponse(bool Success); 

    public class SetUserPasswordEndpoint : Endpoint<SetUserPasswordRequest, SetUserPasswordResponse>
    {
        public override void Configure()
        {
            Put("/api/users/password"); 
        }

        public override async Task HandleAsync(SetUserPasswordRequest req, CancellationToken ct)
        {
            var command = new SetUserPasswordCommmand(req.Password, req.VerificationPassword, "sebastian.urregog@udea.edu.co").ExecuteAsync();

            await Send.OkAsync(); 
        }
    }
}
