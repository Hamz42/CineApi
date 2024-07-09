
using MC.Cine.DTO.Dto.Departamento;

namespace MC.Cine.DTO.Dto.Municipio
{
    public class MunicipioDto
    {
        public MunicipioDto() 
        {
            Departamento = new DepartamentoDto();
        }
        public int Id { get; set; }

        public int DepartamentoId { get; set; }

        public string Codigo { get; set; } = null!;

        public string Municipio { get; set; } = null!;

        public DepartamentoDto Departamento { get; set; }
    }
}
