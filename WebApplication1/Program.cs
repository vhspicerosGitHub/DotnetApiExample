using System.Reflection;
using Microsoft.OpenApi.Models;

namespace WebApplication1;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();

        builder.Services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Version = "v1",
                Title = "Ejemplo de una api sencilla",
                Description = "API ASP.NET Core 9",
                Contact = new OpenApiContact
                {
                    Name = "Victor Hugo Saavedra",
                    Email = "vhspiceros@gmail.com",
                }
            });
        });

        
        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();
        builder.Services.RegisterDependencies();

        var app = builder.Build();
        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();


        app.Run();
    }
}