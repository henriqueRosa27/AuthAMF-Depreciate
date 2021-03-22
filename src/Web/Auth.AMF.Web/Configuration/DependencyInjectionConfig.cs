using Auth.AMF.Web.Data;
using Auth.AMF.Web.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Auth.AMF.Web.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<MongoContext>();
        }
    }
}
