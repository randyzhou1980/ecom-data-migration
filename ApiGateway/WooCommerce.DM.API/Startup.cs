using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Extensions;
using DMService.Neto;
using DMService.Neto.Repo;
using DMService.WooCommerce.Config;
using DMService.WooCommerce.Repo;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace WooCommerce.DM.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddControllersAsServices();

            services.AddCorsPolicy();

            services.Configure<WooCommerceSetting>(Configuration.GetSection("apiSettings:wooCommerceSetting"));
            services.Configure<NetoSetting>(Configuration.GetSection("apiSettings:netoSetting"));

            services.AddSwaggerGen(Configuration["ApiVersion"], "WooCommerce");

            services.AddTransient<IWCommServiceRepo, WCommServiceRepo>();
            services.AddTransient<INetoServiceRepo, NetoServiceRepo>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();

            app.UseMvcWithDefaultRoute();

            app.UseSwagger(Configuration["ApiVersion"], "WooCommerce");
        }
    }
}
