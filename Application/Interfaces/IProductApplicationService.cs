using API.DDD.Application.Dtos;
using System;
using System.Collections.Generic;

namespace API.DDD.Application.Interfaces
{
    public interface IProductApplicationService
    {
        void Add(ProductDto produtoDto);
        void Update(ProductDto produtoDto);
        void Remove(ProductDto produtoDto);
        IEnumerable<ProductDto> GetAll();
        ProductDto GetById(Guid id);
    }
}
