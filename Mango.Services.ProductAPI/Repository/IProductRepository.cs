using Mango.Services.ProductAPI.Models.DTOs;

namespace Mango.Services.ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDTO>> GetProducts();

        Task<ProductDTO> GetProduct(int productId);

        Task<ProductDTO> SaveProduct(ProductDTO productDTO);

      

        Task<bool> DeleteProduct(int productId);
    }
}
