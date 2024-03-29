using Dapper.API.DI.Provider;
using Microsoft.Extensions.DependencyInjection;
using DryIoc.Microsoft.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Dapper.API.Data.Interfaces.Base;
using Dapper.API.Data.Implementations.Base;
using Dapper.API.Data.Interfaces.CompanyRepository;
using Dapper.API.Data.Implementations.CompanyRepository;
using Dapper.API.Service.Interfaces;
using Dapper.API.Service.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.UseServiceProviderFactory(new DIProvider());
//var serviceProvider = new DIProvider().CreateServiceProvider(IContainer container);
builder.Services.AddScoped<IBaseRepository, BaseRepository>();
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
builder.Services.AddScoped<ICompanyService, CompanyService>();

var app = builder.Build();

//var host = Host.CreateDefaultBuilder(args)
//    .UseServiceProviderFactory(new YourCustomServiceProviderFactory()) // Register your custom service provider factory
//    .ConfigureWebHostDefaults(webBuilder =>
//    {
//        webBuilder.UseStartup<Startup>();
//    })
//    .Build();

//await host.RunAsync();

// Register your custom service provider factory
//app.UseServiceProviderFactory(new DIProvider());

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
