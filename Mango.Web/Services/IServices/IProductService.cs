using Mango.Web.Models;

namespace Mango.Web.Services.IServices
{
    public interface IProductService : IBaseService
    {
        Task<T> GetAllProductsAsync<T>();

        Task<T> GetProductByIdAsync<T>(int productId);

        Task<T> CreateProductAsync<T>(ProductDTO productDTO);

        Task<T> UpdateProductAsync<T>(ProductDTO productDTO);

        Task<T> DeleteProductAsync<T>(int productId);
    }
}
