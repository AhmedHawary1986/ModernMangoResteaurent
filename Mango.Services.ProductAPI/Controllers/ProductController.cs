using Mango.Services.ProductAPI.Models.DTOs;
using Mango.Services.ProductAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private ResponseDTO _responseDTO;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
            this._responseDTO = new ResponseDTO();
        }

        [HttpGet]
        public async Task<ResponseDTO> Get()
        {
            try
            {
                var productList = await _productRepository.GetProducts();
                this._responseDTO.IsSuccess = true;
                this._responseDTO.Result = productList;
            }
            catch (Exception ex)
            {
                this._responseDTO.IsSuccess = false;
                this._responseDTO.ErrorMessages = new List<string> { ex.Message };
            }

            return this._responseDTO;
        }


        [HttpGet("GetProduct")]
        public async Task<ResponseDTO> GetProduct(int id)
        {
            try
            {
                var product = await _productRepository.GetProduct(id);
                this._responseDTO.IsSuccess = true;
                this._responseDTO.Result = product;
            }
            catch (Exception ex)
            {
                this._responseDTO.IsSuccess = false;
                this._responseDTO.ErrorMessages = new List<string> { ex.Message };
            }

            return this._responseDTO;
        }

        [HttpDelete]
        public async Task<ResponseDTO> Delete(int id)
        {
            try
            {
                this._responseDTO.IsSuccess = await _productRepository.DeleteProduct(id);
            }
            catch (Exception ex)
            {
                this._responseDTO.IsSuccess = false;
                this._responseDTO.ErrorMessages = new List<string> { ex.Message };
            }

            return this._responseDTO;
        }

        [HttpPost]
        public async Task<ResponseDTO> Post([FromBody]ProductDTO productDTO)
        {
            try
            {
                var product = await _productRepository.SaveProduct(productDTO);
                this._responseDTO.IsSuccess = true;
                this._responseDTO.Result = product;
            }
            catch (Exception ex)
            {
                this._responseDTO.IsSuccess = false;
                this._responseDTO.ErrorMessages = new List<string> { ex.Message };
            }

            return this._responseDTO;
        }

        [HttpPut]
        public async Task<ResponseDTO> Put([FromBody] ProductDTO productDTO)
        {
            try
            {
                var product = await _productRepository.SaveProduct(productDTO);
                this._responseDTO.IsSuccess = true;
                this._responseDTO.Result = product;
            }
            catch (Exception ex)
            {
                this._responseDTO.IsSuccess = false;
                this._responseDTO.ErrorMessages = new List<string> { ex.Message };
            }

            return this._responseDTO;
        }

    }
}
