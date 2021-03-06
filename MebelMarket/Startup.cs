using MebelMarket.Infrastructure.Interfaces;
using MebelMarket.Infrastructure.Services.InSQL;
using MebelMarket.Infrastructure.Services.Notify;
using MebelMarket.SqlDataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MebelMarket
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
            services.AddTransient<Notify>();
            services.AddControllersWithViews();

            //services.AddDbContext<MebelMarketContext>(opt =>
            //    opt.UseSqlite(@"Data Source=/tmp/market.db", b => b.MigrationsAssembly("MebelMarket")));

            services.AddDbContext<MebelMarketContext>(opt =>
                opt.UseSqlite(@"Data Source=D:\Apps\mebelmarket\market.db", b => b.MigrationsAssembly("MebelMarket")));

            services.AddScoped<IFurnitureData, SQLFurnitureData>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //app.UseExceptionHandler("/Home/Error");
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
