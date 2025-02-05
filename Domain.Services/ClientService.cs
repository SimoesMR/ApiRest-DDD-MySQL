using API.DDD.Core.Interfaces.Repositorys;
using API.DDD.Domain.Entitys;
using Domain.Services;

namespace API.DDD.Infrastructure.Data.Repositorys
{
    public class ClientService : BaseService<Client>, IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository) : base(clientRepository)
        {
            _clientRepository = clientRepository;
        }
    }
}
