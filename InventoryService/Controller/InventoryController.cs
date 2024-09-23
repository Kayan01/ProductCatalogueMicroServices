using InventoryService.Interfaces;
using InventoryService.Model;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.InventoryService.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryService _inventoryService;

        public InventoryController(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }

    


        [HttpGet]
        public async Task<ActionResult<IEnumerable<InventoryItem>>> GetAllInventoryItems()
        {
            var items = await _inventoryService.GetAllInventoryItemsAsync();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<InventoryItem>> GetInventoryItemsById(int id)
        {
            var items = await _inventoryService.GetInventoryItemByIdAsync(id);
            if (items == null)
            {
                return NotFound();
            }
            return Ok(items);
        }

        [HttpPost]
        public async Task<ActionResult<InventoryItem>> CreateProduct(InventoryItem item)
        {
            var items = await _inventoryService.CreateInventoryItemAsync(item);
            return CreatedAtAction(nameof(GetInventoryItemsById), new { id = items.Id }, items);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateInventoryItems(int id, InventoryItem item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            await _inventoryService.UpdateInventoryItemAsync(item);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInventoryItem(int id)
        {
            await _inventoryService.DeleteInventoryItemAsync(id);
            return NoContent();
        }
    }

}
