using BikeRental.Models;
using BikeRental.Services.Resource_Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<RentalDbContext>();
builder.Services.AddScoped<ResourceService>();
builder.Services.AddScoped<CategoryService>();
builder.Services.AddScoped<FramesizeService>();
builder.Services.AddScoped<ReservationDateService>();
builder.Services.AddScoped<ReservationTicketService>();

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
