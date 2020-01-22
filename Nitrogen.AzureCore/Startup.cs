using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Nitrogen.Data.Mysql.Data;
using Nitrogen.ILogic.SystemILogic;
using Nitrogen.Logic;
using Nitrogen.Logic.SystemLogic;

namespace Nitrogen.AzureCore
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
            services.AddDbContext<MySqlDbContext>(options =>
            {
                options.UseMySql(Configuration.GetConnectionString("DefaultConnectionStr"));
            });
            services.AddTransient<PermissionsCategoryILogic, PermissionsCategoryLogic>();
            services.AddTransient<PermissionsILogic, PermissionsLogic>();
        }

        private void InitializeDb(DbContext context)
        {
            if (context.Database.GetPendingMigrations().Any())
                context.Database.Migrate();//项目运行时执行自动迁移
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, MySqlDbContext mySqlDbContext)
        {
            // var _dBcontext = new MySqlDbContext(app.ApplicationServices.GetRequiredService<DbContextOptions<MySqlDbContext>>());
            InitializeDb(mySqlDbContext);
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
            app.UseHttpsRedirection();
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
