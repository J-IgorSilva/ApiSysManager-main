﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SysManager.Application.Data.MySql.Repositories;
using SysManager.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SysManager.API.Admin
{
    public class Startup
    {
        public void BeforeConfigureServices(IServiceCollection services)
        {

        }

        public void ConfigureServices(IServiceCollection services)
        {
            BeforeConfigureServices(services);
            services.AddApiVersioning();
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddScoped<UserService>();
            services.AddScoped<UserRepository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
