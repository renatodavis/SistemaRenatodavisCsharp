using renatodavis.app.api.Exceptions;
using renatodavis.app.domain.entities;
using renatodavis.app.domain.interfaces;

namespace renatodavis.app.api.Services
{
    public interface IClienteService
    {

        public Task<Cliente> CriarClienteAsync(Cliente novoCliente);


        public Task<Cliente> AtualizarClienteAsync(int id, Cliente clienteAtualizado);

        public void RemoverCliente(int id);

        public Task<List<Cliente>> GetClientesAsync();
        
    }
}
