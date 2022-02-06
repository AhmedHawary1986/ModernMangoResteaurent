using AutoMapper;
using Mango.Services.ProductAPI.DbContexts;
using Mango.Services.ProductAPI.Models;
using Mango.Services.ProductAPI.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private ApplicationDbContext _db;

        private IMapper _mapper;

        public ProductRepository(ApplicationDbContext DB,IMapper Mapper)
        {
            _db = DB;
            _mapper = Mapper;
        }
        public async Task<bool> DeleteProduct(int productId)
        {
            var product = _db.Products.FirstOrDefault(x => x.ProductId == productId);
            if(product == null)
            {
                return  false;
            }
            else
            {
                _db.Products.Remove(product);
                await _db.SaveChangesAsync();
                return true;
            }
        }

        public async Task<ProductDTO> GetProduct(int productId)
        {
            var product = await _db.Products.FirstOrDefaultAsync(x => x.ProductId == productId);
            return _mapper.Map<ProductDTO>(product);
        }

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            var products = await _db.Products.ToListAsync();
            return _mapper.Map<IEnumerable<ProductDTO>>(products);
        }

        public async Task<ProductDTO> SaveProduct(ProductDTO productDTO)
        {
            var product = _mapper.Map<ProductDTO, Product>(productDTO);

            if (product.ProductId>0)
            {
                _db.Products.Update(product);
            }
            else
            {
                await _db.Products.AddAsync(product);
            }
            await _db.SaveChangesAsync();
            return _mapper.Map<Product, ProductDTO>(product);
        }

      
    }
}
