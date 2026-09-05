namespace BuildingBlocks.Exceptions.Common
{
    public sealed class BadRequestException : BaseException
    {
        public BadRequestException(string message) : base("BadRequest", message)
        {
            
        }
    }
}
