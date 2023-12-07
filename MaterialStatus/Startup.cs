using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using MaterialStatus.Service;

namespace MaterialStatus
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration) { Configuration = configuration; }

        public void ConfigureServices(IServiceCollection services)
        {            
            Configuration.Bind("Project", new Config());
            services.AddMvc();

            //services.AddIdentity<IdentityUser, IdentityRole>(opts =>
            //{
            //    opts.User.RequireUniqueEmail = true;
            //    opts.Password.RequiredLength = 6;
            //    opts.Password.RequireNonAlphanumeric = false;
            //    opts.Password.RequireLowercase = false;
            //    opts.Password.RequireUppercase = false;
            //    opts.Password.RequireDigit = false;
            //}).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

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
        }
        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseStaticFiles();

            //--
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{Id?}");
            });
        }
    }
}
