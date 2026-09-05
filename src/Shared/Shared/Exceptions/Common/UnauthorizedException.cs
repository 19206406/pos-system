namespace BuildingBlocks.Exceptions.Common
{
    public sealed class UnauthorizedException : BaseException
    {
        public UnauthorizedException(string message) : base("Unauthorized", message)
        {
            
        }
    }
}
