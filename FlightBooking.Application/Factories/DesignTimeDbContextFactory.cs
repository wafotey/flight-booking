using FlightBooking.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FlightBooking.Application.Factories
{
 	public class DesignTimeDbContextFactory: IDesignTimeDbContextFactory<BookingDbContext>
    {

        public BookingDbContext CreateDbContext(string[] args)
        {
            string path = Directory.GetCurrentDirectory();

            IConfigurationBuilder builder =
                new ConfigurationBuilder()
                    .SetBasePath(path)
                    .AddJsonFile("appsettings.json");

            IConfigurationRoot config = builder.Build();

            string connectionString = config.GetConnectionString(nameof(BookingDbContext)) ?? string.Empty;

            Console.WriteLine($"DesignTimeDbContextFactory: using base path = {path}");
            Console.WriteLine($"DesignTimeDbContextFactory: using connection string = {connectionString}");

            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException($"Could not find connection string named {nameof(BookingDbContext)}");
            }

            DbContextOptionsBuilder<BookingDbContext> dbContextOptionsBuilder =
                new DbContextOptionsBuilder<BookingDbContext>();
            dbContextOptionsBuilder.UseSqlServer(connectionString);
            // BulkTestDbContext.AddBaseOptions(dbContextOptionsBuilder, connectionString);

            return new BookingDbContext(dbContextOptionsBuilder.Options,config);
        }


    }
}