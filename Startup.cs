using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Server.Models;
using Server.Data.EFCore;
using Server.ReadTextStrategy;
using Server.Services;
using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace Server
{
    public class Startup
    {
        public static IList<IAccessText> strategiesList = new List<IAccessText>();
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddMvc();
            services.AddDbContext<ServerContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("ServerContext")));

            services.AddScoped<EfCoreTextExampleRepository>();

            services.AddSingleton<IHandleTextService, HandleTextService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            InitStrategies();

        }
        public void InitStrategies()
        {
            strategiesList.Add(new AccessFakeDatabase());
            strategiesList.Add(new AccessFile());
        }
    }
}
