using Autofac;
using Autofac.Extensions.DependencyInjection;
using FlightBooking.Application;
using FlightBooking.Application.HostedServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

builder.Services.AddHostedService<MigrationHostedService>();

builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen(c =>
{
    
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "FlightBooking API", Version = "v1" });
});
// Register controllers
builder.Services.AddControllers();

builder.Services.AddAuthorization();
builder.Services.AddIdentityApiEndpoints<IdentityUser>(opt => 
                                                { 
                                                    opt.Password.RequiredLength = 8; 
                                                    opt.User.RequireUniqueEmail = true; 
                                                    opt.Password.RequireNonAlphanumeric = false;
                                                    opt.SignIn.RequireConfirmedEmail = true; 
                                                })
        .AddEntityFrameworkStores<BookingDbContext>();

var app = builder.Build();

// If in Development environment, configure Swagger and redirect to it
if (app.Environment.IsDevelopment())
{
    // Enable Swagger and Swagger UI
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "FlightBooking API v1"));

    // Redirect the root ("/") to Swagger UI
    app.MapGet("/", (HttpContext http) => http.Response.Redirect("/swagger"));
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.MapIdentityApi<IdentityUser>();
app.MapControllers();

app.Run();
