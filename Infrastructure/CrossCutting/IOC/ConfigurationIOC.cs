using API.DDD.Application;
using API.DDD.Application.Interfaces;
using API.DDD.Application.Interfaces.Mapper;
using API.DDD.Application.Mapper;
using API.DDD.Core.Interfaces.Repositorys;
using API.DDD.Infrastructure.Data.Repositorys;
using Autofac;
using Domain.Services;

namespace API.DDD.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC
            builder.RegisterType<ClientApplicationService>().As<IClientApplicationService>();
            builder.RegisterType<ProductApplicationService>().As<IProductApplicationService>();
            builder.RegisterType<OrderApplicationService>().As<IOrderApplicationService>();

            builder.RegisterType<ClientService>().As<IClientService>();
            builder.RegisterType<ProductService>().As<IProductService>();

            builder.RegisterType<ClientRepository>().As<IClientRepository>();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();

            builder.RegisterType<ClientMapper>().As<IClientMapper>();
            builder.RegisterType<ProductMapper>().As<IProductMapper>();

            #endregion
        }
    }
}
