using API.DDD.Application.Dtos;
using API.DDD.Application.Interfaces.Mapper;
using API.DDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace API.DDD.Application.Mapper
{
    public class OrderMapper : IOrderMapper
    {
        List<OrderDto> orderDto = new List<OrderDto>();

        public Order MapperDtoToEntity(OrderDto orderDto)
        {
            Order order = new Order()
            {
                Id = orderDto.Id,
                InclusionDate = orderDto.InclusionDate,
                ChangeDate = orderDto.ChangeDate,
                Excluded = orderDto.Excluded,
                ClientId = orderDto.ClientId,
                
            };

            return order;
        }

        public OrderDto MapperEntityToDto(Order order)
        {
            OrderDto orderDto = new OrderDto()
            {
                Id = order.Id,
                InclusionDate = order.InclusionDate,
                ChangeDate = order.ChangeDate,
                Excluded = order.Excluded,
                ClientId = order.ClientId,
            };

            return orderDto;
        }

        public IEnumerable<OrderDto> MapperListOrderDto(IEnumerable<Order> orders)
        {
            var dto = orders.Select(p => new OrderDto
                                                        {
                                                            Id = p.Id,
                                                            InclusionDate = p.InclusionDate,
                                                            ChangeDate = p.ChangeDate,
                                                            Excluded = p.Excluded,
                                                            ClientId = p.ClientId
                                                        });

            return dto;
        }
    }
}
