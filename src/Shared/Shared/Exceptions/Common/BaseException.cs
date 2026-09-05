namespace BuildingBlocks.Exceptions.Common
{
    public abstract class BaseException : Exception
    {
        public string Code { get; }

        protected BaseException(string code, string message) : base(message)
        {
            Code = code; 
        }
    }
}
