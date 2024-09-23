using InventoryService.Model;

namespace InventoryService.Interfaces
{
    public interface IInventoryService
    {
        Task<IEnumerable<InventoryItem>> GetAllInventoryItemsAsync();
        Task<InventoryItem> GetInventoryItemByIdAsync(int id);
        Task<InventoryItem> CreateInventoryItemAsync(InventoryItem item);
        Task UpdateInventoryItemAsync(InventoryItem item);
        Task DeleteInventoryItemAsync(int id);
    }
}
