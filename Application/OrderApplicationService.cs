using API.DDD.Application.Dtos;
using API.DDD.Application.Interfaces;
using API.DDD.Application.Interfaces.Mapper;
using Domain.Services;
using System;
using System.Collections.Generic;

namespace API.DDD.Application
{
    public class OrderApplicationService : IOrderApplicationService
    {
        private readonly IOrderService _orderService;
        private readonly IOrderMapper _orderMapper;

        public OrderApplicationService(IOrderService orderService, IOrderMapper orderMapper)
        {
            _orderService = orderService;
            _orderMapper = orderMapper;
        }

        public void Add(OrderDto orderDto)
        {
            var order = _orderMapper.MapperDtoToEntity(orderDto);
            _orderService.Add(order);
        }

        public IEnumerable<OrderDto> GetAll()
        {
            var orders = _orderService.GetAll();
            return _orderMapper.MapperListOrderDto(orders);
        }

        public OrderDto GetById(Guid id)
        {
            var order = _orderService.GetById(id);
            return _orderMapper.MapperEntityToDto(order);
        }

        public void Remove(OrderDto orderDto)
        {
            var order = _orderMapper.MapperDtoToEntity(orderDto);
            _orderService.Remove(order);
        }

        public void Update(OrderDto orderDto)
        {
            var order = _orderMapper.MapperDtoToEntity(orderDto);
            _orderService.Update(order);
        }
    }
}
