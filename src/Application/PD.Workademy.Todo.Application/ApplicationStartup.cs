using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PD.Workademy.Todo.Application.Interfaces;
using PD.Workademy.Todo.Application.Services;

namespace PD.Workademy.Todo.Application
{
    public class ApplicationStartup
    {
        public IConfigurationRoot Configuration { get; }

        public ApplicationStartup(IConfigurationRoot configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ITodoItemService, TodoItemService>();
        }
    }
}
