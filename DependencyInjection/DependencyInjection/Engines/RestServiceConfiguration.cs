using DependencyInjection.Interfaces;

namespace DependencyInjection.Engines
{
    public class RestServiceConfiguration : IRestServiceConfiguration
    {
        public void Configure(IRestServiceProvider provider)
        {
            provider.URL = "TEST_URL";
        }
    }
}
