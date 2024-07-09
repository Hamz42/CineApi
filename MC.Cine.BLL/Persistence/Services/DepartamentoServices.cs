using MC.Cine.BLL.Interfaces.Repository;
using MC.Cine.BLL.Interfaces.Services;
using MC.Cine.BLL.Persistence.Repository;
using MC.Cine.DTO.Dto.Departamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.Cine.BLL.Persistence.Services
{
    public class DepartamentoServices : IDepartamentoServices
    {
        private readonly IDepartamentoRepository _departamentoRepository;

        public DepartamentoServices(IDepartamentoRepository departamentoRepository)
        {
            _departamentoRepository = departamentoRepository;
        }

        public IEnumerable<DepartamentoDto> GetAll()
        {
            var lista = _departamentoRepository.GetAll();

            return lista.Select(x => new DepartamentoDto
            {
                Id = x.Id,
                PaisId = x.PaisId,
                Codigo = x.Codigo,
                Departamento = x.Departamento
            }).ToList();
        }

        public IEnumerable<DepartamentoDto> GetByPaisId(int paisId)
        {
            var lista = _departamentoRepository.Get(x => x.PaisId == paisId);

            return lista.Select(x => new DepartamentoDto
            {
                Id = x.Id,
                PaisId = x.PaisId,
                Codigo = x.Codigo,
                Departamento = x.Departamento
            }).ToList();
        }
    }
}

