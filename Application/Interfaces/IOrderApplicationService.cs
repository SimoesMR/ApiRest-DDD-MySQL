using API.DDD.Application.Dtos;
using System;
using System.Collections.Generic;

namespace API.DDD.Application.Interfaces
{
    public interface IOrderApplicationService
    {
        void Add(OrderDto orderDto);
        void Update(OrderDto orderDto);
        void Remove(OrderDto orderDto);
        IEnumerable<OrderDto> GetAll();
        OrderDto GetById(Guid id);
    }
}
