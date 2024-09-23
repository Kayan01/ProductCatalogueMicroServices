using ProductService.Models;

namespace ProductService.Interfaces
{
    public interface IProductRepository
    {
        //    Task<IEnumerable<Product>> GetAllAsync();
        Task<IEnumerable<Product>> GetAllAsync(int pageNumber, int pageSize);
        Task<Product> GetByIdAsync(int id);
        Task<Product> AddAsync(ProductDTO product);
        Task UpdateAsync(ProductDTO product);
        Task DeleteAsync(int id);
    }
}
