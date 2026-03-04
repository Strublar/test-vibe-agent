var builder = WebApplication.CreateBuilder(args);

// Configuration des services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configuration Kestrel (serveur HTTP)
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(5000); // HTTP
    options.ListenAnyIP(5001, configure => configure.UseHttps()); // HTTPS
});

var app = builder.Build();

// Configuration du pipeline de requête (middlewares)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

// Configuration basique pour la route ping
app.MapGet("/ping", () => "pong")
   .WithName("Ping")
   .WithOpenApi();

app.Run();