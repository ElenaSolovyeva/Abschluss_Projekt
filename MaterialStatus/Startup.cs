using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using MaterialStatus.Service;
using MaterialStatus.Domain;
using MaterialStatus.Domain.Repositories.Abstract;
using MaterialStatus.Domain.Repositories.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

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
            services.AddMvc();

            services.AddTransient<IAppUsersRepository, EFAppUsersRepository>();
            services.AddTransient<IGroupsRepository, EFGroupsRepository>(); 
            services.AddTransient<IDepartmentsRepository, EFDepartmentsRepository>();
            services.AddTransient<DataManager>();

            services.AddDbContext<AppDbContext>(item => item.UseSqlServer(Config.ConnectionStringTest)); //! ConnectionString_B, ..G

            services.AddIdentity<IdentityUser, IdentityRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequiredLength = 2;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

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

            app.UseStaticFiles();

            app.UseRouting();

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
