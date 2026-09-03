using BuildingBlocks.Exceptions;
using FastEndpoints;
using FastEndpoints.Swagger;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using User.Api.Common.Database;

var builder = WebApplication.CreateBuilder(args);

// connection string 
var connectionString = builder.Configuration.GetConnectionString("SchemaUserDb");

// IdentityDbContext 
builder.Services.AddDbContext<IdentityDbContext>(options =>
{
    options.UseNpgsql(connectionString);
});

// FastEndpoints 
builder.Services
    .AddFastEndpoints()
    .SwaggerDocument(options =>
    {
        options.DocumentSettings = settings =>
        {
            settings.Title = "Users Api";
            settings.Version = "v1";
            settings.Description = "API for user, role and permission management";
        }; 
    });

// Exceptions 
builder.Services.AddSharedExceptionHandling(); 

var app = builder.Build();

// Exceptions
app.UseExceptionHandler(); 

// Database Migration 
DatabaseMigrator.ApplyMigrations(connectionString!); 

// FastEndpoints
app.UseFastEndpoints(c => c.Errors.UseProblemDetails());

// scalar 
app.UseSwaggerGen(options =>
{
    options.Path = "/openapi/{documentName}.json";
});

app.MapScalarApiReference(options =>
{
    options.WithTitle("Users API Documentation"); 
});

app.Run();
