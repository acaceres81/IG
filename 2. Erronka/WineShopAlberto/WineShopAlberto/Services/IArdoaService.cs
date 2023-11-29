using WineShopAlberto.Models;

namespace WineShopAlberto.Services
{
    public interface IArdoaService
    {
        Task<IList<ArdoaUpeltegi>> GetMota(int id);
    }
}
