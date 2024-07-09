using MC.Cine.DTO.Dto.Seguridad;

namespace MC.Cine.BLL.Interfaces.Repository
{
    public interface ISeguridadRepository
    {
        IEnumerable<PermisosAccionesPorEstadosDto> GetAccionesPorEstados(PermisosRequest request);

        IEnumerable<PermisosEstadosPorPerfilModuloDto> GetEstadosPorPerfilModuloDto(PermisosRequest request);
    }
}
