using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ModelsLayer;
using ModelsLayer.DAL;
using System;
using System.Threading.Tasks;

namespace DCSCoreFramework
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;            
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);            
            services.AddDbContext<WorkContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"], provOption => provOption.CommandTimeout(300)));

            //services.AddScoped<GameContext, GameContext>();

            DBSuscription.SuscriveModels(services);

        }
       
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())            
                app.UseDeveloperExceptionPage();
            
            else            
                app.UseHsts();

            app.Use(async (context, next) =>
            {
                // Do work that doesn't write to the Response.
                await next.Invoke();
                // Do logging or other work that doesn't write to the Response.
            });
            //app.Run(async context =>
            //{
            //    await Task.Delay(100);
            //});

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
