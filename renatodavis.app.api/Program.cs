using Microsoft.EntityFrameworkCore;
using renatodavis.app.domain.interfaces;
using renatodavis.app.infra.repositores;
using renatodavis.app.infra.Contexto;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddTransient<IClienteRepository, ClienteRepository>();

builder.Services.AddDbContext<AppContexto>(
    options => options.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=LojaDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
