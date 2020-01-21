using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

using BlazorAppPrint.Shared;

namespace BlazorAppPrint
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<Person>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
