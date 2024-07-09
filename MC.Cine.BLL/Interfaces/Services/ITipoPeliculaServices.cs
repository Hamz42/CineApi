using MC.Cine.DTO.Dto.TipoPelicula;

namespace MC.Cine.BLL.Interfaces.Services
{
    public interface ITipoPeliculaServices
    {
        IEnumerable<TipoPeliculaDto> GetAllActivos();
    }
}
