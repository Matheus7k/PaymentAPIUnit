using Microsoft.EntityFrameworkCore;
using PaymentAPI;
using PaymentAPI.Infra.Repository.Context;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<PaymentAPIContext>(options =>
   options.UseSqlServer(builder.Configuration.GetConnectionString("PaymentAPIContext")));
// Add services to the container.

var config = builder.Configuration;

builder.Services.AddInjections(config);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
