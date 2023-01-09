using DockerUOW.Data;
using DockerUOW.Dto.MappingProfile;
using DockerUOW.Repository.UnitOfWork;
using DockerUOW.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DockerDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DockerUowConnectionString"));
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//UOF DI
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

//Automapper DI
builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddTransient<IStudentService, StudentService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
