namespace renatodavis.app.api.Exceptions
{
    public class ApiException : Exception
    {
        public int ErrorCode { get; }

        public ApiException(int errorCode, string message) : base(message)
        {
            ErrorCode = errorCode;
        }

        public ApiException(int errorCode, string message, Exception innerException) : base(message, innerException)
        {
            ErrorCode = errorCode;
        }
    }
}
