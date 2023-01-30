using API.DDD.Core.Interfaces.Repositorys;
using API.DDD.Domain.Entitys;
using API.DDD.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.DDD.Infrastructure.Data.Repositorys
{
    public class ClientRepository : BaseRepository<Client>, IClientRepository
    {
        private readonly MySqlContext _mySqlContext;

        public ClientRepository(MySqlContext mySqlContext) : base(mySqlContext)
        {
            _mySqlContext = mySqlContext;
        }
    }
}
