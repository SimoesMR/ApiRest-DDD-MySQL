using API.DDD.Application.Dtos;
using API.DDD.Application.Interfaces;
using API.DDD.Application.Interfaces.Mapper;
using Domain.Services;
using System;
using System.Collections.Generic;

namespace API.DDD.Application
{
    public class ClientApplicationService : IClientApplicationService
    {
        private readonly IClientService _clientService;
        private readonly IClientMapper _clientMapper;

        public ClientApplicationService(IClientService clientService, IClientMapper clientMapper)
        {
            _clientService = clientService;
            _clientMapper = clientMapper;
        }

        public void Add(ClientDto clientDto)
        {
            var client = _clientMapper.MapperDtoToEntity(clientDto);
            _clientService.Add(client);
        }

        public IEnumerable<ClientDto> GetAll()
        {
            var clients = _clientService.GetAll();
            return _clientMapper.MapperListClientDto(clients);
        }

        public object GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ClientDto GetById(Guid id)
        {
            var client = _clientService.GetById(id);
            return _clientMapper.MapperEntityToDto(client);
        }

        public void Remove(ClientDto clientDto)
        {
            var client = _clientMapper.MapperDtoToEntity(clientDto);
            _clientService.Remove(client);
        }

        public void Update(ClientDto clientDto)
        {
            var client = _clientMapper.MapperDtoToEntity(clientDto);
            _clientService.Update(client);
        }
    }
}
