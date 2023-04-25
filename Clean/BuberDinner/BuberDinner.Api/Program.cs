using BuberDinner.Application;
using BuberDinner.Infrastructure;
using BuberDinner.Api;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
{
    builder.Services
        .AddInfrastructure(builder.Configuration)
        .AddPresentation()
        .AddApplication();

    
}

var app = builder.Build();

{
    app.UseAuthentication();
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
};


