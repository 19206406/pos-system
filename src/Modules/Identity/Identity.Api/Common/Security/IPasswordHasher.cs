namespace Identity.Api.Common.Security
{
    public interface IPasswordHasher
    {
        public string Hash(string password);
        public bool Verify(string password, string storedHash); 
    }
}
