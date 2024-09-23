using InventoryService.Interfaces;
using InventoryService.Model;

namespace InventoryService.Services
{
    public class InventoryService : IInventoryService
    {
        private readonly IInventoryRepository _inventoryRepository;

        public InventoryService(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }

        // Implement the methods defined in the IInventoryService interfac
        // Similar to the ProductService implementation

        public async Task<IEnumerable<InventoryItem>> GetAllInventoryItemsAsync()
        {
            return await _inventoryRepository.GetAllAsync();
        }

        public async Task<InventoryItem> GetInventoryItemByIdAsync(int id)
        {
            return await _inventoryRepository.GetByIdAsync(id);
        }

        public async Task<InventoryItem> CreateInventoryItemAsync(InventoryItem item)
        {
            return await _inventoryRepository.AddAsync(item);
        }

        public async Task DeleteInventoryItemAsync(int id)
        {
            await _inventoryRepository.DeleteAsync(id);
        }

        public async Task UpdateInventoryItemAsync(InventoryItem item)
        {
            await _inventoryRepository.UpdateAsync(item);
        }
    }
}

