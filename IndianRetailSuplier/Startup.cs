using IndianRetailSuplier.Common.AutoMapper;
using IndianRetailSuplier.CustomeFilter;
using IndianRetailSuplier.DATA.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Server.IISIntegration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndianRetailSuplier
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
            services.AddControllersWithViews();
            
           services.AddControllersWithViews(config => config.Filters.Add(typeof(CustomExceptionFilter)));
            // services.AddAuthentication(IISDefaults.AuthenticationScheme);
            services.AddDbContext<DataContext>(item => item.UseSqlServer(Configuration.GetConnectionString("myconn")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.Use(async (context, next) =>
            {
                await next();
                if (context.Response.StatusCode == 404)
                {
                    context.Request.Path = "/Errors/404/index.html";
                    await next();
                }
            });
            // app.UseStatusCodePagesWithRedirects("/Home/MyStatusCode?code={0}");
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            IRS_WebAutoMapperConfiguration.Configure(IRS_WebAutoMapperConfiguration.MappingExpressions);
            IndianRetailSuplierAutoMapper.Initialize(IRS_WebAutoMapperConfiguration.MappingExpressions);
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            string Date = DateTime.Now.ToString();
            string path = "E:\\NetLearningProject\\IndianRetailSuplier\\IndianRetailSuplier";
            loggerFactory.AddFile($"{path}\\Logs\\Log.txt");
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
