using FastEndpoints;
using User.Api.Common.Database;
using User.Api.Common.Database.Entities;

namespace User.Api.Users.RegisterUser
{
    public record RegisterUserCommand(string FullName, string Email, string PhoneNumber, string Position) 
        : ICommand<RegisterUserResponse>;

    public class RegisterUserHandler : ICommandHandler<RegisterUserCommand, RegisterUserResponse>
    {
        private readonly IdentityDbContext _context;

        public RegisterUserHandler(IdentityDbContext context)
        {
            _context = context;
        }

        public async Task<RegisterUserResponse> ExecuteAsync(RegisterUserCommand command, CancellationToken ct)
        {
            var newUser = new Common.Database.Entities.User
            {
                FullName = command.FullName,
                PhoneNumber = command.FullName,
                JobTitle = command.Position,
                Email = command.Email,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };

            _context.Add(newUser);
            await _context.SaveChangesAsync();

            return new RegisterUserResponse(newUser.Id.ToString()); 
        }        
    }
}
