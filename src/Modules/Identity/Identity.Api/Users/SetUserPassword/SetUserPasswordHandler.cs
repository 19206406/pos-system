using BuildingBlocks.Exceptions.Common;
using FastEndpoints;
using Identity.Api.Common.Security;
using Microsoft.EntityFrameworkCore;
using User.Api.Common.Database;

namespace Identity.Api.Users.SetUserPassword
{
    public record SetUserPasswordCommmand(string Password, string VerificationPassword, string Email) : ICommand<SetUserPasswordResponse>;
    public class SetUserPasswordHandler : ICommandHandler<SetUserPasswordCommmand, SetUserPasswordResponse>
    {
        private readonly IdentityDbContext _context;
        private readonly IPasswordHasher _passwordHasher;

        public SetUserPasswordHandler(IdentityDbContext context, IPasswordHasher passwordHasher)
        {
            _context = context;
            _passwordHasher = passwordHasher;
        }

        public async Task<SetUserPasswordResponse> ExecuteAsync(SetUserPasswordCommmand command, CancellationToken ct)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == command.Email);

            if (user is null)
                throw new UnauthorizedException("You cannot perform the following action.");

            // TODO: Check if the user is active 

            if (user.HashPassword is null)
                throw new UnauthorizedException("You cannot perform the following action.");


            var password = _passwordHasher.Hash(command.Password);
            user.HashPassword = password;

            await _context.SaveChangesAsync();

            return new SetUserPasswordResponse(true); 
        }
    }
}
