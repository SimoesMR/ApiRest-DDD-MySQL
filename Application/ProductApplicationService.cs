using API.DDD.Application.Dtos;
using API.DDD.Application.Interfaces;
using API.DDD.Application.Interfaces.Mapper;
using Domain.Services;
using System;
using System.Collections.Generic;

namespace API.DDD.Application
{
    public class ProductApplicationService : IProductApplicationService
    {
        private readonly IProductService _productService;
        private readonly IProductMapper _productMapper;

        public ProductApplicationService(IProductService productService, IProductMapper productMapper)
        {
            _productService = productService;
            _productMapper = productMapper;
        }

        public void Add(ProductDto productDto)
        {
            var product = _productMapper.MapperDtoToEntity(productDto);
            _productService.Add(product);
        }

        public IEnumerable<ProductDto> GetAll()
        {
            var products = _productService.GetAll();
            return _productMapper.MapperListProductDto(products);
        }

        public ProductDto GetById(Guid id)
        {
            var product = _productService.GetById(id);
            return _productMapper.MapperEntityToDto(product);
        }

        public void Remove(ProductDto productDto)
        {
            var product = _productMapper.MapperDtoToEntity(productDto);
            _productService.Remove(product);
        }

        public void Update(ProductDto productDto)
        {
            var product = _productMapper.MapperDtoToEntity(productDto);
            _productService.Update(product);
        }
    }
}
