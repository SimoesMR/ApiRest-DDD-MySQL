using API.DDD.Core.Interfaces.Repositorys;
using API.DDD.Domain.Entitys;
using API.DDD.Infrastructure.Context;

namespace API.DDD.Infrastructure.Data.Repositorys
{
    public class OrderProductRepository : BaseRepository<OrderProduct>, IOrderProductRepository
    { 
        private readonly MySqlContext _mySqlContext;

        public OrderProductRepository(MySqlContext mySqlContext) : base(mySqlContext)
        {
            _mySqlContext = mySqlContext;
        }
    }
}
