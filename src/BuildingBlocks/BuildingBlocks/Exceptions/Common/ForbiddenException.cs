namespace BuildingBlocks.Exceptions.Common
{
    public sealed class ForbiddenException : BaseException
    {
        public ForbiddenException(string message) : base("Forbidden", message)
        {
            
        }
    }
}
