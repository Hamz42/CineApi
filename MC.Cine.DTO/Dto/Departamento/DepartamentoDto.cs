
using MC.Cine.DTO.Dto.Pais;

namespace MC.Cine.DTO.Dto.Departamento
{
    public class DepartamentoDto
    {
        public DepartamentoDto()
        {
            Pais = new PaisDto();
        }
        public int Id { get; set; }

        public int PaisId { get; set; }

        public int Codigo { get; set; }

        public string Departamento { get; set; } = null!;

        public PaisDto Pais { get; set; }
    }
}
