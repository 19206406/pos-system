namespace BuildingBlocks.Exceptions.Common
{
    public sealed class BusinessException : BaseException
    {
        public BusinessException(string message) : base("Business", message)
        {
        }
    }
}
