using Autofac.Configuration;
using Autofac;
using Autofac.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure Autofac container
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
{
    // Load Autofac configuration from the JSON file
    var config = new ConfigurationBuilder()
        .AddJsonFile("autofac.json", optional: false, reloadOnChange: true)
        .Build();

    var module = new ConfigurationModule(config);
    containerBuilder.RegisterModule(module);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
