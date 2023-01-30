using API.DDD.Application.Dtos;
using API.DDD.Domain.Entitys;
using System.Collections.Generic;

namespace API.DDD.Application.Interfaces.Mapper
{
    public interface IClientMapper
    {
        Client MapperDtoToEntity(ClientDto clientDto);
        IEnumerable<ClientDto> MapperListClientDto(IEnumerable<Client> clients);
        ClientDto MapperEntityToDto(Client client);
    }
}
