using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetManagment.Application.Common.Interfaces;

namespace FleetManagment.DataAccess
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FleetManagmentDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("FleetManagmentDbContext")));
            services.AddScoped<IFleetManagmentDbContext, FleetManagmentDbContext>();
            return services;
        }
    }
}
