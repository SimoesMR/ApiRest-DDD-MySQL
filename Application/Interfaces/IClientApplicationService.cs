using API.DDD.Application.Dtos;
using System;
using System.Collections.Generic;

namespace API.DDD.Application.Interfaces
{
    public interface IClientApplicationService
    {
        void Add(ClientDto clientDto);
        void Update(ClientDto clientDto);
        void Remove(ClientDto clientDto);
        IEnumerable<ClientDto> GetAll();
        ClientDto GetById(Guid id);
    }
}
