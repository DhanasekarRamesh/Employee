using Microsoft.EntityFrameworkCore;
using employee_management_api.Data;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDBContext>(
    opt => opt.UseMySql(builder.Configuration.GetConnectionString("constring"),ServerVersion.Parse("5.5.51-mysql"))
);

// Add services to the container.

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
