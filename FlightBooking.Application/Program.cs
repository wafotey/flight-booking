using Autofac;
using Autofac.Extensions.DependencyInjection;
using FlightBooking.Application.HostedServices;
using FlightBooking.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddDbContext<BookingDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString(nameof(BookingDbContext)), options =>
    {
        options.MigrationsAssembly(typeof(BookingDbContext).Assembly.FullName);
        options.EnableRetryOnFailure();
    }));

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory(cb =>
{
    cb.RegisterAssemblyModules(typeof(Program).Assembly);
}));

//builder.Services.AddHostedService<MigrationHostedService>();

//builder.Services.AddAutofac();
builder.Services.AddOpenApi();

builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapControllers();


app.Run();
 