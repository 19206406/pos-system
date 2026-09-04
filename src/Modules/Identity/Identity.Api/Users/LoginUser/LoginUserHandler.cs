using BuildingBlocks.Exceptions.Common;
using FastEndpoints;
using Identity.Api.Common.Security;
using Microsoft.EntityFrameworkCore;
using User.Api.Common.Database;

namespace Identity.Api.Users.LoginUser
{
    public record LoginUserCommand(string Email, string Password) : ICommand<LoginUserResponse>;

    public class LoginUserHandler : ICommandHandler<LoginUserCommand, LoginUserResponse>
    {
        private readonly IdentityDbContext _context;
        private readonly IPasswordHasher _passwordHasher;

        public LoginUserHandler(IdentityDbContext context, IPasswordHasher passwordHasher)
        {
            _context = context;
            _passwordHasher = passwordHasher;
        }

        public async Task<LoginUserResponse> ExecuteAsync(LoginUserCommand command, CancellationToken ct)
        { 
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == command.Email);

            // validations 
            if (user is null)
                throw new UnauthorizedException("You cannot perfom this action.");

            if (user.HashPassword is null)
                throw new UnauthorizedException("You cannot perform this action."); 

            // compare hash-password
            bool comparePasswords = _passwordHasher.Verify(command.Password, user.HashPassword);

            if (!comparePasswords)
                throw new UnauthorizedException("The credentials do not match. Please try again."); 
            
            // TODO: Generate JWT-Token 

            return new LoginUserResponse(true); 
        }
    }
}
