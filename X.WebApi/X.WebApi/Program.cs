using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Xml.Xsl;
using X.Data.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Projeto X", Version = "v1" }));

//configuração de banco 
builder.Services.AddDbContext<XContext>(options => options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DB_Projeto_X;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSwagger();

app.UseSwaggerUI(c =>
{
    c.RoutePrefix = string.Empty;
    c.SwaggerEndpoint("./swagger/v1/swagger.json", "X V1");
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
