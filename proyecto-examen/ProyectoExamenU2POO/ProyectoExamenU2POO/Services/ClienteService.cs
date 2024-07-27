using AutoMapper;
using ProyectoExamenU2POO.Database;
using ProyectoExamenU2POO.Database.Entities;
using ProyectoExamenU2POO.Dtos.Clientes;
using ProyectoExamenU2POO.Dtos.Common;
using ProyectoExamenU2POO.Services.Interfaces;

namespace ProyectoExamenU2POO.Services
{
    public class ClienteService : IClienteService
    {

        private readonly ProyectoExamenContext _context;
        private readonly IMapper _mapper;

        public ClienteService(ProyectoExamenContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }

        public async Task<ResponseDto<ClienteDto>> CreateAsync(ClienteCreateDto dto)
        {

            var clienteEntity = _mapper.Map<ClienteEntity>(dto);
            _context.Clientes.Add(clienteEntity);
            await _context.SaveChangesAsync();

            var clienteEntityDto = _mapper.Map<ClienteDto>(clienteEntity);

            return new ResponseDto<ClienteDto>
            {
                StatusCode = 201,
                Status = true,
                Message = "Cliente creado correctamente.",
                Data = clienteEntityDto,
            };

        }
    }
}
