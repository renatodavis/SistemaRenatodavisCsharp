using Microsoft.AspNetCore.Server.IIS.Core;
using renatodavis.app.api.Exceptions;
using renatodavis.app.domain.entities;
using renatodavis.app.domain.interfaces;

namespace renatodavis.app.api.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<Cliente> CriarClienteAsync(Cliente novoCliente)
        {
            try
            {
                if (_clienteRepository.bExisteEmail(novoCliente.email))
                {
                    throw new EmailJaExisteException(novoCliente.email);
                }

                await _clienteRepository.Add(novoCliente);

                return novoCliente;
            }
            catch (ApiException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public async Task<Cliente> AtualizarClienteAsync(int id, Cliente clienteAtualizado)
        {
            try
            {
                var clienteExistente = await _clienteRepository.GetById(id);

                if (clienteExistente == null)
                {
                    throw new ClienteNaoEncontradoException(id);
                }

                if (_clienteRepository.bExisteEmail(clienteAtualizado.email) && clienteAtualizado.email != clienteExistente.email)
                {
                    throw new EmailJaExisteException(clienteAtualizado.email);
                }

                clienteExistente.Nome = clienteAtualizado.Nome;
                clienteExistente.email = clienteAtualizado.email;
                clienteExistente.telefone = clienteAtualizado.telefone;

                await _clienteRepository.Update(clienteExistente);

                return clienteExistente;
            }
            catch (ApiException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Cliente>> GetClientesAsync()
        {
            try
            {
                return await _clienteRepository.GetClientesAsync();
            }
            catch (ApiException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoverCliente(int id)
        {
            try
            {
                _clienteRepository.RemoverCliente(id);
            }
            catch (ApiException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

}
