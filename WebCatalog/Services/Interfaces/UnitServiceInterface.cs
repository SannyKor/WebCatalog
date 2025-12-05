using WebCatalog.Models;

namespace WebCatalog.Services.Interfaces
{
    public interface UnitServiceInterface
    {
        Task<IEnumerable<Unit>> GetAllAsync();
        Task<Unit?> GetUnitByIdAsinc(int id);
        Task<Unit> AddUnitAsync(Unit unit);
        Task<bool> UpdateUnitAsync(Unit unit);
        Task<bool> DeleteUnitAsync(int id);
    }
}
