using HelixComponents.Foundation.Content.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace HelixComponents.Foundation.Content.DI
{
    public class RegisterContainer : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IContentRepository, ContentRepository>();
            serviceCollection.AddTransient<IRenderingRepository, RenderingRepository>();
            serviceCollection.AddTransient<IContextRepository, ContextRepository>();
        }
    }
}
