using Dapper.API.DI.Registrator;
using DryIoc;
using DryIoc.Microsoft.DependencyInjection;

namespace Dapper.API.DI.Provider
{
    public class DIProvider : IServiceProviderFactory<IContainer>
    {
        public IContainer CreateBuilder(IServiceCollection services)
        {
            return new Container().WithDependencyInjectionAdapter(services);
        }

        public IServiceProvider CreateServiceProvider(IContainer containerBuilder)
        {
            return containerBuilder.ConfigureServiceProvider<DIRegistrator>();
        }
    }
}
