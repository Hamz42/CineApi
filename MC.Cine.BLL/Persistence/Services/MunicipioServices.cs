using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.DTO.Dto.Municipio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.Cine.BLL.Persistence.Services
{
    public class MunicipioServices : IMunicipioServices
    {
        private readonly IMunicipioRepository _municipioRepository;

        public MunicipioServices(IMunicipioRepository municipioRepository)
        {
            _municipioRepository = municipioRepository;
        }

        public IEnumerable<MunicipioDto> GetAll()
        {
            var lista = _municipioRepository.GetAll();

            return lista.Select(x => new MunicipioDto
            {
                Id = x.Id,
                DepartamentoId = x.DepartamentoId,
                Codigo = x.Codigo,
                Municipio = x.Municipio
            }).ToList();
        }

        public IEnumerable<MunicipioDto> GetByDepartamentoId(int departamentoId)
        {
            var lista = _municipioRepository.Get(x => x.DepartamentoId == departamentoId);

            return lista.Select(x => new MunicipioDto
            {
                Id = x.Id,
                DepartamentoId = x.DepartamentoId,
                Codigo = x.Codigo,
                Municipio = x.Municipio
            }).ToList();
        }
    }
}

