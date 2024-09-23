using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;
using ProductService.Data;
using ProductService.Interfaces;
using ProductService.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ProductService.Service
{
    public class ProductsService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductsService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync(int pageNumber, int pageSize)
        {
            return await _productRepository.GetAllAsync(pageNumber, pageSize);
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _productRepository.GetByIdAsync(id);
        }

        public async Task<Product> CreateProductAsync(ProductDTO product)
        {
            return await _productRepository.AddAsync(product);
        }

        public async Task UpdateProductAsync(ProductDTO product)
        {
            await _productRepository.UpdateAsync(product);
        }

        public async Task DeleteProductAsync(int id)
        {
            await _productRepository.DeleteAsync(id);
        }
    }
}
