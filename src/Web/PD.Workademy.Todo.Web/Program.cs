using PD.Workademy.Todo.Application;
using Startup = PD.Workademy.Todo.Web.Startup;

var builder = WebApplication.CreateBuilder(args);
var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);
var applicationStartup = new ApplicationStartup(builder.Configuration);
applicationStartup.ConfigureServices(builder.Services);
var app = builder.Build();
startup.Configure(app);
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.Run();
