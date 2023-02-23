using myApp02.DAL.DBContext;
using Microsoft.EntityFrameworkCore;
using myApp02.DAL.Repositories.Interfaces;
using myApp02.DAL.Repositories.Implementations;
using myApp02.Services.Implementations;
using myApp02.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container

builder.Services.AddDbContext <ApplicationDBContext> (options => options.UseSqlServer(builder.Configuration.GetConnectionString("EmployeeCS")));
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddTransient<IEmployeeService, EmployeeService>();

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
