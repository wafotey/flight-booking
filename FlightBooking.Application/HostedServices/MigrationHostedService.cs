using System.Reflection;
using FlightBooking.Infrastructure;
using FlightBooking.Infrastructure.Seedings;
using Microsoft.EntityFrameworkCore;

namespace FlightBooking.Application.HostedServices
{
    public class MigrationHostedService : IHostedService
    {
        private readonly IServiceProvider _serviceProvider;

        public MigrationHostedService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<BookingDbContext>();
                await dbContext.Database.MigrateAsync(cancellationToken);

                await RunSeedersAsync();
            }
        }

        public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;

        private async Task RunSeedersAsync()
        {
            var seederTypes = GetSeederTypes();

            if (seederTypes == null || seederTypes.Count() == 0) // Invoke Count() method
            {
                throw new InvalidOperationException("No seeder types found.");
            }

            var context = _serviceProvider.GetRequiredService<BookingDbContext>();

            foreach (var seederType in seederTypes)
            {
                
                if (context == null)
                {
                    throw new InvalidOperationException($"Service {nameof(BookingDbContext)} not found.");
                }

                var seeder = _serviceProvider.GetService(seederType) as IDatabaseSeeder
                             ?? ActivatorUtilities.CreateInstance(_serviceProvider, seederType, context) as IDatabaseSeeder;

                if (seeder == null)
                {
                    throw new InvalidOperationException($"Seeder for type {seederType.Name} not found or could not be created.");
                }

                seeder.Seed();
            }

            await context.SaveChangesAsync();
        }

        private Type[] GetSeederTypes()
        {
           var assembly = typeof(IDatabaseSeeder).Assembly;
            var seederInterface = typeof(IDatabaseSeeder);

            return assembly.GetTypes()
                .Where(t => seederInterface.IsAssignableFrom(t) && !t.IsAbstract && !t.IsInterface)
                .ToArray();
        }

    }

}