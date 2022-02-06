using Mango.Web.Models;
using Mango.Web.Services.IServices;

namespace Mango.Web.Services
{
    public class ProductService : BaseService, IProductService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ProductService(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<T> CreateProductAsync<T>(ProductDTO productDTO)
        {
            return await this.SendAsync<T>(new APIRequest()
            {
                ApiType = SD.APIType.POST,
                URL = SD.ProductAPIBase + "/api/product",
                Data = productDTO,
                AccessToken = ""
            }); ;
        }

        public async Task<T> DeleteProductAsync<T>(int productId)
        {
            return await this.SendAsync<T>(new APIRequest()
            {
                ApiType = SD.APIType.DELETE,
                URL = SD.ProductAPIBase + "/api/product/"+ productId,
                AccessToken = ""
            }); 
        }

        public async Task<T> GetAllProductsAsync<T>()
        {
            return await this.SendAsync<T>(new APIRequest()
            {
                ApiType = SD.APIType.GET,
                URL = SD.ProductAPIBase + "/api/product/",
                AccessToken = ""
            });
        }

        public async Task<T> GetProductByIdAsync<T>(int productId)
        {
            return await this.SendAsync<T>(new APIRequest()
            {
                ApiType = SD.APIType.GET,
                URL = SD.ProductAPIBase + "/api/product/GetProduct?id="+productId,
                AccessToken = ""
            });
        }

        public async Task<T> UpdateProductAsync<T>(ProductDTO productDTO)
        {
            return await this.SendAsync<T>(new APIRequest()
            {
                ApiType = SD.APIType.PUT,
                URL = SD.ProductAPIBase + "/api/product",
                Data = productDTO,
                AccessToken = ""
            }); ;
        }
    }
}
