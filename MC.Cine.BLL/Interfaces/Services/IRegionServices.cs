using MC.Cine.DTO.Dto.Region;
namespace MC.Cine.BLL.Interfaces.Services
{
    public interface IRegionServices
    {
        IEnumerable<RegionDto> Get(int idPadre);
    }
}
