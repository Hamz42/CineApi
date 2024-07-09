using MC.Cine.DTO.Dto.Seguridad;

namespace MC.Cine.BLL.Interfaces.Services
{
    public interface ISeguridadServices
    {
        IEnumerable<PermisosAccionesPorEstadosDto> GetAccionesPorEstados(PermisosRequest request);

        IEnumerable<PermisosEstadosPorPerfilModuloDto> GetEstadosPorPerfilModuloDto(PermisosRequest request);
    }
}
