using Microsoft.EntityFrameworkCore;
using StudentsApp.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container. (context added)
builder.Services.AddDbContext<AppdbContext>(options => options.UseMySql(builder.Configuration.GetConnectionString("CnnStr")!));

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
