using API.DDD.Application.Dtos;
using API.DDD.Application.Interfaces.Mapper;
using API.DDD.Domain.Entitys;
using System.Collections.Generic;
using System.Linq;

namespace API.DDD.Application.Mapper
{
    public class ClientMapper : IClientMapper
    {
        List<ClientDto> clientDto = new List<ClientDto>();

        public Client MapperDtoToEntity(ClientDto clientDto)
        {
            Client client = new Client()
            {
                Id = clientDto.Id,
                InclusionDate = clientDto.InclusionDate,
                ChangeDate = clientDto.ChangeDate,
                Name = clientDto.Name,
                LastName = clientDto.LastName,
                Email = clientDto.Email
            };

            return client;
        }

        public ClientDto MapperEntityToDto(Client client)
        {
            ClientDto clientDto = new ClientDto()
            {
                Id = client.Id,
                InclusionDate = client.InclusionDate,
                ChangeDate = client.ChangeDate,
                Name = client.Name,
                LastName = client.LastName,
                Email = client.Email
            };

            return clientDto;
        }

        public IEnumerable<ClientDto> MapperListClientDto(IEnumerable<Client> clients)
        {
            var dto = clients.Select(c => new ClientDto
            {
                Id = c.Id,
                InclusionDate = c.InclusionDate,
                ChangeDate = c.ChangeDate,
                Name = c.Name,
                LastName = c.LastName,
                Email = c.Email
            });

            return dto;
        }
    }
}
