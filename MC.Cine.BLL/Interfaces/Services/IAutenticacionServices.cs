using MC.Cine.DTO.Dto.Autenticacion;
namespace MC.Cine.BLL.Interfaces.Services
{
    public interface IAutenticacionServices
    {
        Task<LoginUsuarioDto> LoginAsync(LoginUsuarioRequest request);
        Task<bool> ValidarTokenAsync(string token);

    }
}
