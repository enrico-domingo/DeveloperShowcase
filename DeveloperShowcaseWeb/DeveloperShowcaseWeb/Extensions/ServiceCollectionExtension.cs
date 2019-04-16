using DeveloperShowcaseWeb.Infrastracture.Resilience;
using DeveloperShowcaseWeb.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeveloperShowcaseWeb.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void ConfigureAppServices(this IServiceCollection services, IConfiguration config)
        {
            AddApplicationServices(services, config);
        }

        private static void AddApplicationServices(IServiceCollection services, IConfiguration config)
        {
            services.Configure<AppSettings>(config);
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<ICardService, CardService>();
            services.AddSingleton<IHttpClient, StandardHttpClient>();
        }
    }
}
