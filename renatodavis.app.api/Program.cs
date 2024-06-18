using Microsoft.EntityFrameworkCore;
using renatodavis.app.domain.interfaces;
using renatodavis.app.infra.repositores;
using renatodavis.app.infra.Contexto;
using renatodavis.app.api;
using renatodavis.app.api.Services;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using renatodavis.app.api.renatodavis.app.api;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddTransient<IClienteService, ClienteService>();
builder.Services.AddTransient<IClienteRepository, ClienteRepository>();


builder.Services.AddDbContext<AppContexto>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionStrings")));


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors(policy => policy.AllowAnyHeader()
                            .AllowAnyMethod()
                            .SetIsOriginAllowed(origin => true)
                            .AllowCredentials());


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseMiddleware<ExceptionMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseCors("AllowAllOrigins");

app.Run();
