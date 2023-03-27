using Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public static class ServiceRegisteration
    {
        public static void AddServicesConfigurations(this IServiceCollection services)
        {
            services.AddSingleton<IBuildingService, BuildingService>();
        }
    }
}
