using AutoMapper;
using ProyectoExamenU2POO.Database.Entities;
using ProyectoExamenU2POO.Dtos.Clientes;

namespace ProyectoExamenU2POO.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
           MapsForClientes();
        }

        private void MapsForClientes()
        {
           // CreateMap<ORIGEN, DESTINO>();
            CreateMap<PrestamoEntity, PrestamoDto>();

            CreateMap<PrestamoCreateDto, PrestamoEntity>();
        
   
        }
    }
}
