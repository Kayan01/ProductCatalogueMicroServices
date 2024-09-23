using InventoryService.Data;
using InventoryService.Model;
using Microsoft.EntityFrameworkCore;

namespace InventoryService.Interfaces
{
    public interface IInventoryRepository
    {
        Task<IEnumerable<InventoryItem>> GetAllAsync();
        Task<InventoryItem> GetByIdAsync(int id);
        Task<InventoryItem> AddAsync(InventoryItem item);
        Task UpdateAsync(InventoryItem item);
        Task DeleteAsync(int id);
    }
   

    
}
