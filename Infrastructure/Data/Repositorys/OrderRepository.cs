using API.DDD.Core.Interfaces.Repositorys;
using API.DDD.Domain.Entitys;
using API.DDD.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.DDD.Infrastructure.Data.Repositorys
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        private readonly MySqlContext _mySqlContext;

        public OrderRepository(MySqlContext mySqlContext) : base(mySqlContext)
        {
            _mySqlContext = mySqlContext;
        }
    }
}
