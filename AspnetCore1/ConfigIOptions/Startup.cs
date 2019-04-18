﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ConfigIOptions
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            AppConfiguration = configuration;
        }
        
        public IConfiguration AppConfiguration { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            // Настройка параметров и DI
            services.AddOptions();

            // создание объекта Person по ключам из конфигурации
            services.Configure<Person>(AppConfiguration);
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMiddleware<PersonMiddleware>();
        }
    }
}
