using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProyectoExamenU2POO.Database;
using ProyectoExamenU2POO.Database.Entities;
using ProyectoExamenU2POO.Dtos.Clientes;
using ProyectoExamenU2POO.Dtos.Common;
using ProyectoExamenU2POO.Services.Interfaces;

namespace ProyectoExamenU2POO.Services
{
    public class PrestamoService : IPrestamoService
    {

        private readonly ProyectoExamenContext _context;
        private readonly ILogger<PrestamoService> _logger;
        private readonly IMapper _mapper;

        public PrestamoService(ProyectoExamenContext context, IMapper mapper, ILogger<PrestamoService> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;

        }


        public async Task<ResponseDto<PrestamoDto>> CreateAsync(PrestamoCreateDto dto)
        {
            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    var nombreExiste = await CheckEntity(dto);
                    if (!nombreExiste) 
                    {
                        return new ResponseDto<PrestamoDto>
                        {
                            StatusCode = 409,
                            Status = false,
                            Message = "El cliente ya existe en la base de datos"
                        };
                    }
                    var clienteEntity = _mapper.Map<PrestamoEntity>(dto);
                    _context.Prestamos.Add(clienteEntity);
                    await _context.SaveChangesAsync();

                    var prestamoEntityDto = _mapper.Map<PrestamoDto>(clienteEntity);
                    await transaction.CommitAsync();
                    return new ResponseDto<PrestamoDto>
                    {
                        StatusCode = 201,
                        Status = true,
                        Message = "Informarmación del Prestamo del Cliente guardada correctamente.",
                        Data = prestamoEntityDto,
                    };
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync(); 
                    _logger.LogError(ex, "Error al crear el plan de amortización."); 
                    return new ResponseDto<PrestamoDto> 
                    {
                        StatusCode = 500,
                        Status = false,
                        Message = "Se produjo un error al crear el plan de amortización."
                    };

                }



            }


        }


        private async Task<bool> CheckEntity(PrestamoCreateDto dto)
        {
            var prestamos = await _context.Prestamos.ToListAsync();
            var formattedClienteName = dto.NombreCliente.ToUpper().Trim();
            return !prestamos.Any(p => p.NombreCliente.ToUpper().Trim() == formattedClienteName);

            // retorna TRUE si no se encuentra ningún producto con un nombre que coincida con el nombre del DTO; de lo contrario, retorna FALSE.
        }

    }
}
