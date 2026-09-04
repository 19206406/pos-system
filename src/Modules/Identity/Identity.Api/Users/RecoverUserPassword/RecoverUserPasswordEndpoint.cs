using FastEndpoints;

namespace Identity.Api.Users.RecoverUserPassword
{
    public record RecoverUserPasswordRequest();
    public record RecoverUserPasswordResponse(); 
    public class RecoverUserPasswordEndpoint : Endpoint<RecoverUserPasswordRequest, RecoverUserPasswordResponse>
    {
        public override void Configure()
        {
            base.Configure();
        }

        public override Task HandleAsync(RecoverUserPasswordRequest req, CancellationToken ct)
        {
            return base.HandleAsync(req, ct);
        }
    }
}
