using MC.Cine.DTO.Dto.Personas;

namespace MC.Cine.BLL.Interfaces.Services
{
    public interface IPersonaServices
    {
        IEnumerable<PersonasDto> GetAll();

        PersonaDetalleDto Find(int id);
    }
}
