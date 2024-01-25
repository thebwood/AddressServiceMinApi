using AddressServiceMinApi.Api;
using AddressServiceMinApi.Api.Endpoints;
using AddressServiceMinApi.Core;
using AddressServiceMinApi.Infrastructure;
using Serilog;

string siteCorsPolicy = "SiteCorsPolicy";

var builder = WebApplication.CreateBuilder(args);
{

    builder.Services.AddCors(options =>
    {
        options.AddPolicy(siteCorsPolicy,
                           builder =>
                           {
                               builder.WithOrigins("http://localhost:7292")
                                                   .AllowAnyHeader()
                                                   .AllowAnyMethod()
                                                   .AllowCredentials();
                           });
    });

    builder.Services
        .AddPresentation()
        .AddDomain()
        .AddInfrastructure(builder.Configuration.GetConnectionString("Database");


}


builder.Host.UseSerilog((context, configuration) => configuration.ReadFrom.Configuration(context.Configuration));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(siteCorsPolicy);
app.UseSerilogRequestLogging();

app.UseHttpsRedirection();

app.MapAddressEndpoints();

app.Run();

