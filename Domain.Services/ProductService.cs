using API.DDD.Core.Interfaces.Repositorys;
using API.DDD.Domain.Entitys;
using Domain.Services;
using System;
using System.Collections.Generic;

namespace API.DDD.Infrastructure.Data.Repositorys
{
    public class ProductService : BaseService<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository) : base(productRepository)
        {
            _productRepository = productRepository;
        }
    }
}
