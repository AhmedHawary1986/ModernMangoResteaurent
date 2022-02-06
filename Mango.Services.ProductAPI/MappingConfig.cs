using AutoMapper;
using Mango.Services.ProductAPI.Models;
using Mango.Services.ProductAPI.Models.DTOs;

namespace Mango.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMap()
        {
            var mapperConfiguration = new MapperConfiguration( config =>
            {
                config.CreateMap<Product, ProductDTO>();
                config.CreateMap<ProductDTO, Product>();
            }
                );

            return mapperConfiguration;
        }
    }
}
