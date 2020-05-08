using Autofac;
using DependencyInjection.Engines;
using DependencyInjection.Interfaces;

namespace DependencyInjection
{
    public class ServiceRegistrator : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            //We need to register our implementations with Autofac.
            builder.RegisterType<RestServiceConfiguration>().As<IRestServiceConfiguration>();
            builder.RegisterType<RestServiceProvider>().As<IRestServiceProvider>();
        }
    }
}
