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
        private readonly IPrestamoService _clienteService;

        public ClientController(IPrestamoService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPost]
        public async Task<ActionResult<ResponseDto<PrestamoDto>>> Create(PrestamoCreateDto dto)
        {
            var response = await _clienteService.CreateAsync(dto);
            return StatusCode(response.StatusCode, response);
        }
    }
}
