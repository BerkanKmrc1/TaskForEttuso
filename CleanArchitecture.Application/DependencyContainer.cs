using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Data.Context;
using CleanArchitecture.Data.Repositories;
using CleanArchitecture.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CleanArchitecture.Application
{
    public static class DependencyContainer
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<PersonalContext>(options =>
                                                options.UseSqlServer(configuration.GetConnectionString("Default"))
                                                .UseLazyLoadingProxies());
                                                     
            services.AddScoped<IPersonalService, PersonalService>();
            services.AddScoped<IPersonalRepository, PersonalRepository>();
            services.AddScoped<IPhoneService, PhoneService>();
            services.AddScoped<IPhoneRepository, PhoneRepository>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;

        }
    }
}
