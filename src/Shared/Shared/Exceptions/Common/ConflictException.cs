namespace BuildingBlocks.Exceptions.Common
{
    public sealed class ConflictException : BaseException
    {
        public ConflictException(string message) : base("Conflict", message)
        {
            
        }
    }
}
