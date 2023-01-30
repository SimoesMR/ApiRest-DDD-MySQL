using API.DDD.Application.Dtos;
using API.DDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.DDD.Application.Interfaces.Mapper
{
    public interface IProductMapper
    {
        Product MapperDtoToEntity(ProductDto productDto);
        IEnumerable<ProductDto> MapperListProductDto(IEnumerable<Product> products);
        ProductDto MapperEntityToDto(Product product);
    }
}
