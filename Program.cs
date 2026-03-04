using Microsoft.OpenApi.Models;

namespace TestVibeAgent
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Configuration des services
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo 
                { 
                    Title = "Test Vibe Agent API", 
                    Version = "v1",
                    Description = "API simple avec endpoint ping/pong"
                });
            });

            // Configuration CORS pour permettre les requêtes cross-origin
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(policy =>
                {
                    policy.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader();
                });
            });

            var app = builder.Build();

            // Configuration du pipeline HTTP
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Test Vibe Agent API v1");
                    c.RoutePrefix = string.Empty; // Swagger UI à la racine
                });
            }

            app.UseHttpsRedirection();
            app.UseCors();

            // Configuration du routing pour les contrôleurs
            app.MapControllers();

            // Endpoint racine pour information
            app.MapGet("/", () =>
            {
                return Results.Ok(new { 
                    message = "Test Vibe Agent API", 
                    version = "1.0.0",
                    endpoints = new[] { "/ping" }
                });
            })
            .WithName("Root")
            .WithOpenApi();

            app.Run();
        }
    }
}