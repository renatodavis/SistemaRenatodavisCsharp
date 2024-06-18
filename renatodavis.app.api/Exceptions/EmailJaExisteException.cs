namespace renatodavis.app.api.Exceptions
{
    public class EmailJaExisteException : ApiException
    {
        public EmailJaExisteException(string email)
            : base(400, $"O e-mail '{email}' já está em uso.")
        {
        }
    }
}
