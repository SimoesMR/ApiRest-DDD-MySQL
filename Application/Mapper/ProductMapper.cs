using API.DDD.Application.Dtos;
using API.DDD.Application.Interfaces.Mapper;
using API.DDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace API.DDD.Application.Mapper
{
    public class ProductMapper : IProductMapper
    {
        List<ProductDto> productDto = new List<ProductDto>();

        public Product MapperDtoToEntity(ProductDto productDto)
        {
            Product product = new Product()
            {
                Id = productDto.Id,
                InclusionDate = productDto.InclusionDate,
                ChangeDate = productDto.ChangeDate,
                Name = productDto.Name
            };

            return product;
        }

        public ProductDto MapperEntityToDto(Product product)
        {
            ProductDto productDto = new ProductDto()
            {
                Id = product.Id,
                InclusionDate = product.InclusionDate,
                ChangeDate = product.ChangeDate,
                Name = product.Name,
                Value = product.Value
            };

            return productDto;
        }

        public IEnumerable<ProductDto> MapperListProductDto(IEnumerable<Product> products)
        {
            var dto = products.Select(p => new ProductDto
                                                        {
                                                            Id = p.Id,
                                                            InclusionDate = p.InclusionDate,
                                                            ChangeDate = p.ChangeDate,
                                                            Name = p.Name,
                                                            Value = p.Value
                                                        });

            return dto;
        }
    }
}
