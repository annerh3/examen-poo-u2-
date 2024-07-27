using Microsoft.AspNetCore.Mvc;
using ProyectoExamenU2POO.Dtos.Clientes;
using ProyectoExamenU2POO.Dtos.Common;
using ProyectoExamenU2POO.Services.Interfaces;

namespace ProyectoExamenU2POO.Controllers
{
    [ApiController]
    [Route("api/loans")]
    public class ClientController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClientController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPost]
        public async Task<ActionResult<ResponseDto<ClienteDto>>> Create(ClienteCreateDto dto)
        {
            var response = await _clienteService.CreateAsync(dto);
            return StatusCode(response.StatusCode, response);
        }
    }
}
