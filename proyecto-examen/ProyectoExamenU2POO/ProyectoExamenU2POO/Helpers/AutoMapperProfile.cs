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
            CreateMap<ClienteEntity, ClienteDto>();

            CreateMap<ClienteCreateDto, ClienteEntity>();
        
   
        }
    }
}
