// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using DocNetPostgre;
using DocNetPostgre.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

 // Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Connect to PostgreSQL Database
var connectionString = builder.Configuration["PostgreSQL:ConnectionString"];
builder.Services.AddDbContext<ApplicationContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddHealthChecks();

//... rest of the code omitted for brevity
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

var app = builder.Build();

//... rest of the code omitted for brevity
//builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

// app.UseAuthorization();
app.MapHealthChecks("/healthcheck");

app.MapControllers();

app.MapGet("/", () => "Hello World!");

MigrationExtensions.RunDBMigration(builder.Services);

app.Run();
