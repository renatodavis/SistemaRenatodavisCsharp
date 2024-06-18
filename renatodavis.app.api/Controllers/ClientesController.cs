using Microsoft.AspNetCore.Mvc;
using renatodavis.app.api.Services;
using renatodavis.app.domain.entities;

namespace renatodavis.app.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteService _clienteService;
        
        public ClientesController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        [Route("api/getAll")]
        public async Task<ActionResult<List<Cliente>>> GetClientesAsync()
        {
            var clientes = await _clienteService.GetClientesAsync();
            return Ok(clientes);
        }

        [HttpPost]
        [Route("api/addCliente")]
        public async Task<ActionResult<List<Cliente>>> AddCliente(Cliente cliente)
        {
            try
            {
                await _clienteService.CriarClienteAsync(cliente);
                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { messageError = ex.Message });
            }
            
        }
        
        [HttpPatch]
        [Route("api/update/{id}")]
        public async Task<ActionResult<List<Cliente>>> UpdateCliente(Cliente cliente)
        {
            await _clienteService.AtualizarClienteAsync(cliente.ClienteId, cliente);
            return Ok(cliente);
        }

        [HttpDelete]
        [Route("api/delete/{id}")]
        public ActionResult RemoverCliente(Cliente cliente)
        {
            var clienteExcluido = cliente;
            _clienteService.RemoverCliente(cliente.ClienteId);
            return Ok(clienteExcluido);
        }


    }
}
