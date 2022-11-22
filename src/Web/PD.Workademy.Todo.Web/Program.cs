using PD.Workademy.Todo.Application;
using PD.Workademy.Todo.Infrastructure;
using Startup = PD.Workademy.Todo.Web.Startup;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog(
    (context, config) =>
    {
        config.ReadFrom.Configuration(context.Configuration);
    }
);

var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);
ApplicationStartup applicationStartup = new(builder.Configuration);
applicationStartup.ConfigureServices(builder.Services);
InfrastructureStartup infrastructureStartup = new(builder.Configuration);
infrastructureStartup.ConfigureService(builder.Services);
var app = builder.Build();
startup.Configure(app);
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.Run();
