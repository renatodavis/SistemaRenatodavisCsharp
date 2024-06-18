namespace renatodavis.app.api.Exceptions
{
    public class ClienteNaoEncontradoException : ApiException
    {
        public ClienteNaoEncontradoException(int clienteId)
            : base(404, $"Cliente com ID {clienteId} não encontrado.")
        {
        }
    }
}
