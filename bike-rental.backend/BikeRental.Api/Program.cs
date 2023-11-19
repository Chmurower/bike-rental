using System;
using System.Net.Http;
using BikeRental.Models;
using BikeRental.Services.Resource_Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using System.Net;
using System.Security.Cryptography.X509Certificates;

var builder = WebApplication.CreateBuilder(args);

// Add this code to trust the self-signed certificate
builder.Services.AddHttpClient("MyClient", client =>
{
    client.BaseAddress = new Uri("https://backend:7052/");
})
.ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
{
    ServerCertificateCustomValidationCallback = (sender, cert, chain, errors) => true,
});

builder.WebHost.UseUrls("https://backend:7052");

// Configure Kestrel to use HTTPS with the certificate
builder.WebHost.ConfigureKestrel(serverOptions =>
{
    serverOptions.Listen(IPAddress.Any, 7052, listenOptions =>
    {
        listenOptions.UseHttps(new X509Certificate2("/etc/ssl/certs/cert.pfx", "qwe123"));
    });
});

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<RentalDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<ResourceService>();
builder.Services.AddScoped<CategoryService>();
builder.Services.AddScoped<FramesizeService>();
builder.Services.AddScoped<ReservationTicketService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseSwagger();
    //app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();