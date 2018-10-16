using Microsoft.Extensions.DependencyInjection;
using HelixComponents.Feature.Tabs.Factories;
using Sitecore.DependencyInjection;

namespace HelixComponents.Feature.Tabs.DI
{
    public class RegisterContainer : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ITabFactory, TabFactory>();
        }
    }
}