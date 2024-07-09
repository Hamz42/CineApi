using AutoMapper;
using MC.Cine.BLL.Interfaces.Repository;
using Microsoft.Extensions.Configuration;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.DTO.Dto.Autenticacion;
using MC.Cine.Utils.Security;
using MC.Cine.DTO.Dto.EstadosTramite;
using Azure.Core;
using MC.Cine.BLL.Persistence.Repository;
using MC.Cine.DTO.Dto.Etnia;

namespace MC.Cine.BLL.Persistence.Services
{
    public class EstadosServices : IEstadosServices
    {
        private readonly IEstadoRepository _estadoRepository;

        public EstadosServices(IEstadoRepository estadoRepository)
        {
            _estadoRepository = estadoRepository;
        }

        public IEnumerable<EstadosDto> GetAllEstados()
        {
            var lista = _estadoRepository.GetAll();
            return lista.Select(x => new EstadosDto
            {
                Id = x.Id,
                Estado = x.Estado ?? string.Empty
            }).ToList();
        }

       
    }
}
