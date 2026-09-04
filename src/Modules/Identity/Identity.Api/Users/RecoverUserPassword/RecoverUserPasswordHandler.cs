using FastEndpoints;

namespace Identity.Api.Users.RecoverUserPassword
{
    public record RecoverUserPasswordCommand() : ICommand<RecoverUserPasswordResponse>;
    public class RecoverUserPasswordHandler : ICommandHandler<RecoverUserPasswordCommand, RecoverUserPasswordResponse>
    {

        public RecoverUserPasswordHandler()
        {
            
        }

        public Task<RecoverUserPasswordResponse> ExecuteAsync(RecoverUserPasswordCommand command, CancellationToken ct)
        {
            throw new NotImplementedException();
        }
    }
}
