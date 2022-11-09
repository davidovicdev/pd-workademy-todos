using Microsoft.EntityFrameworkCore;
using PD.Workademy.Todo.Domain.SharedKernel.Interfaces.Repositories;
using PD.Workademy.Todo.Infrastructure.Persistance;
using PD.Workademy.Todo.Infrastructure.Persistance.Repositories;

namespace PD.Workademy.Todo.Web
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; }

        public Startup(IConfigurationRoot configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<UserRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<ITodoItemRepository, TodoItemRepository>();
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("Todos"));
            });
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();
            app.UseEndpoints(x => x.MapControllers());
        }
    }
}
