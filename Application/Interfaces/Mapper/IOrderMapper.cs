using API.DDD.Application.Dtos;
using API.DDD.Domain.Entitys;
using System.Collections.Generic;

namespace API.DDD.Application.Interfaces.Mapper
{
    public interface IOrderMapper
    {
        Order MapperDtoToEntity(OrderDto orderDto);
        IEnumerable<OrderDto> MapperListOrderDto(IEnumerable<Order> orders);
        OrderDto MapperEntityToDto(Order order);
    }
}
