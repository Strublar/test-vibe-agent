using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace TestVibeAgent;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Ajouter les services au container
        builder.Services.AddControllers();

        var app = builder.Build();

        // Configuration du pipeline HTTP
        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        // Configuration du routing pour les contrôleurs
        app.UseRouting();
        app.MapControllers();

        app.Run();
    }
}