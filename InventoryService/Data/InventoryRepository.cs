using InventoryService.Interfaces;
using InventoryService.Model;
using Microsoft.EntityFrameworkCore;

namespace InventoryService.Data
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly InventoryDbContext _context;

        public InventoryRepository(InventoryDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<InventoryItem>> GetAllAsync()
        {
            return await _context.InventoryItems.ToListAsync();
        }

        public async Task<InventoryItem> GetByIdAsync(int id)
        {
            return await _context.InventoryItems.FindAsync(id);
        }

        public async Task<InventoryItem> AddAsync(InventoryItem product)
        {
            _context.InventoryItems.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task UpdateAsync(InventoryItem product)
        {
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var product = await _context.InventoryItems.FindAsync(id);
            if (product != null)
            {
                _context.InventoryItems.Remove(product);
                await _context.SaveChangesAsync();
            }
        }
    }
}
