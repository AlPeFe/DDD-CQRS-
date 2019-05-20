using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using NeoNet.Application.Interfaces;
using NeoNet.Application.Services;
using NeoNet.Domain.Interfaces;
using NeoNet.Infra.Data.Context;
using NeoNet.Infra.Data.Repository;

namespace NeoNet.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //aspnet http context
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // application 
            services.AddScoped<ICustomerAppService, CustomerAppService>();

            //data
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<NeoNetContext>();


        }
    }
}
