using Microsoft.EntityFrameworkCore;
using WebCatalog.Data;
using WebCatalog.Models;

namespace WebCatalog.Services.Implementations
{
    public class UnitService
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
            existingUnit.Quantity = unit.Quantity;
            await _context.SaveChangesAsync();
            return true;


        }
    }
}
