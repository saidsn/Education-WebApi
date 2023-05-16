using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Data;
using RepositoryLayer.Repositories.Implementations;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.Mappings;
using ServiceLayer.Services.Implementations;
using ServiceLayer.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContextPool<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddAutoMapper(typeof(MappingProfile));


builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

builder.Services.AddScoped<ISliderRepository, SliderRepository>();
builder.Services.AddScoped<ISliderService, SliderService>();

builder.Services.AddScoped<IBannerRepository, BannerRepository>();
builder.Services.AddScoped<IBannerService, BannerService>();

builder.Services.AddScoped<ITitleRepository, TitleRepository>();
builder.Services.AddScoped<ITitleService, TitleService>();

builder.Services.AddScoped<IHeaderRepository, HeaderRepository>();
builder.Services.AddScoped<IHeaderService, HeaderService>();

builder.Services.AddScoped<IAboutRepository, AboutRepository>();
builder.Services.AddScoped<IAboutService, AboutService>();

builder.Services.AddScoped<IServiceRepository, ServiceRepository>();
builder.Services.AddScoped<IServiceService, ServiceService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "mycors",
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:3000")
                          .AllowAnyHeader()
                          .AllowAnyMethod();

                      });
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("mycors");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
