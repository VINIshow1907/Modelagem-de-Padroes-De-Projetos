using Microsoft.EntityFrameworkCore;
using Ecommerce.Data.Interfaces;
using Ecommerce.Data.Repositories;
using Ecommerce.Data;
using Ecommerce.Service.Entities;
using Ecommerce.Service.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IPedidoRepository, PedidoRepository>();
builder.Services.AddScoped<IPedidoService, PedidoService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();