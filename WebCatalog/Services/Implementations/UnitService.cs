using Microsoft.EntityFrameworkCore;
using WebCatalog.Data;
using WebCatalog.Models;
using WebCatalog.Services.Interfaces;


namespace WebCatalog.Services.Implementations
{
    public class UnitService : UnitServiceInterface
    {
        private readonly CatalogDbContext _context;
        public UnitService(CatalogDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Unit>> GetAllAsync ()
        {
            return await _context.Units.ToListAsync();
        }
        public async Task<Unit?> GetUnitByIdAsinc (int id)
        {
            return await _context.Units.FindAsync(id);
        }
        public async Task<Unit> AddUnitAsync(Unit unit)
        {
            _context.Units.Add(unit);
            await _context.SaveChangesAsync();
            return unit;
        } 
        public async Task<bool> UpdateUnitAsync (Unit unit)
        {
            var existingUnit = await _context.Units.FindAsync(unit.Id);
            if (existingUnit == null) { return false; }

            existingUnit.Name = unit.Name;
            existingUnit.Description = unit.Description;
            existingUnit.Price = unit.Price;

            bool isQuantityChanged = _context.Entry(existingUnit).Property(u => u.Quantity).IsModified;
            if (isQuantityChanged)
            {
                await _context.Entry(existingUnit).Collection(u => u.QuantityHistory).LoadAsync();
                var quantityLog = new QuantityHistoryLog ()
                {                    
                    UnitId = unit.Id,                    
                    NewUnitQuantity = unit.Quantity,
                    DateOfChange = DateTime.UtcNow,
                    //UserId = currentUser.Id // Assume currentUser is obtained from the context/session
                };
                existingUnit.QuantityHistory.Add (quantityLog);                
            }
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteUnitAsync (int id)
        {
            var unit = await _context.Units.FindAsync(id);
            if (unit == null) { return false; }
            _context.Units.Remove(unit);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
