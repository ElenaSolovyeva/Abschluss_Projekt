using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Microsoft.AspNetCore.Identity;
using MaterialStatus.Service;
using MaterialStatus.Features.SWB.Models;
using MaterialStatus.Features.SWG.Models;

namespace MaterialStatus
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration) 
        { 
            Configuration = configuration; 
        }

        public void ConfigureServices(IServiceCollection services)
        {            
            Configuration.Bind("Project", new Config());
            //services.AddMvc();

            services.AddDbContext<SwbDbContext>(item => item.UseSqlServer(Config.ConnectionStringSWBv2)); 
            services.AddDbContext<SwgDbContext>(item => item.UseSqlServer(Config.ConnectionStringSWGv2));

            //--
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "myCompanyAuth";
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/account/login";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
            });

            services.AddAuthorization(x =>
            {
                x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin"); });
            });

            services.AddControllersWithViews()
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();
                

        }
        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting();

            //--
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{Id?}");
                endpoints.MapControllerRoute("main", "{controller=MainPage}/{action=MainPage}/{Id?}");
                endpoints.MapControllerRoute("admin", "{controller=AdminArea}/{action=AdminArea}/{Id?}");
            });
        }
    }
}
