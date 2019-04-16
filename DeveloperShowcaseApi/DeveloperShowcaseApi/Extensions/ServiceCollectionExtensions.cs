using DeveloperShowcaseApi.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeveloperShowcaseApi.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void ConfigureAppServices(this IServiceCollection services, IConfiguration config, IHostingEnvironment env)
        {
            ConfigureService(services, config, env);
        }

        private static void ConfigureService(IServiceCollection services, IConfiguration config, IHostingEnvironment env)
        {
            services.AddTransient<ICardServices, CardService>();
        }
    }
}
