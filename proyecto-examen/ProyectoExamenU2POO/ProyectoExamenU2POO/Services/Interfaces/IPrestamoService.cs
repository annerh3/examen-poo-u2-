using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProyectoExamenU2POO.Database;
using ProyectoExamenU2POO.Dtos.Clientes;
using ProyectoExamenU2POO.Dtos.Common;

namespace ProyectoExamenU2POO.Services.Interfaces
{
    public interface IPrestamoService
    {
        Task<ResponseDto<PrestamoDto>> CreateAsync(PrestamoCreateDto dto);
    }
}
