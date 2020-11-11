using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebAPI.Repositories.Accounts;
using WebAPI.Repositories.Persons;
using WebAPI.Services.Accounts;
using WebAPI.Services.Persons;

namespace WebAPI
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
            services.AddControllers();
            //services.AddControllers(x => x.AllowEmptyInputInBodyModelBinding = true);
            services.AddMvc()
                    .AddJsonOptions(opts => opts.JsonSerializerOptions.PropertyNamingPolicy = null);

            services.AddScoped<IAccountRepository>(x => new AccountRepository(Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped(typeof(IAccountService), typeof(AccountService));

            services.AddScoped<IPersonRepository>(x => new PersonRepository(Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped(typeof(IPersonService), typeof(PersonService));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseExceptionHandler("/api/Error/CreateLog");
            }
            else
            {
                app.UseExceptionHandler("/api/Error/CreateLog");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "DefaultApi",
                    pattern: "{controller}/{action}/{id?}");

                endpoints.MapControllerRoute(
                    name: "ActionApi",
                    pattern: "api/{controller}/{action}/{id?}");
            });
        }
    }
}
