using Microsoft.AspNetCore.Mvc;
using renatodavis.app.domain.entities;
using renatodavis.app.domain.interfaces;

namespace renatodavis.app.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : Controller
    {
        private readonly IClienteRepository _clienteRepository;
        
        public ClientesController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        [HttpGet]
        public async Task<List<Cliente>> GetClientesAsync()
        {
            return await _clienteRepository.GetClientesAsync();
        }
        
    }
}
