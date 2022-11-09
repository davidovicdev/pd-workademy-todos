using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PD.Workademy.Todo.Domain.SharedKernel.Interfaces.Repositories;
using PD.Workademy.Todo.Infrastructure.Persistance;
using PD.Workademy.Todo.Infrastructure.Persistance.Repositories;

namespace PD.Workademy.Todo.Infrastructure
{
    public class InfrastructureStartup
    {
        public InfrastructureStartup(IConfigurationRoot configurationRoot)
        {
            Configuration = configurationRoot;
        }

        public IConfigurationRoot Configuration { get; }

        public void ConfigureService(IServiceCollection services)
        {
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<ITodoItemRepository, TodoItemRepository>();

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("Todos"));
            });
        }
    }
}
