using FlightBooking.Domain.SharedKennel;
using FlightBooking.Infrastructure.Converters;
using FlightBooking.Infrastructure.Seedings;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FlightBooking.Application
{
     public class BookingDbContext : IdentityDbContext<IdentityUser>
    {
        private readonly IConfiguration _configuration;
        public BookingDbContext(DbContextOptions<BookingDbContext> options, IConfiguration configuration) : base(options)
        {
            
            _configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(IDatabaseSeeder).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
   
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString(nameof(BookingDbContext)), optionsBuilder =>
            {

                optionsBuilder.MigrationsAssembly(typeof(BookingDbContext).Assembly.FullName);
                //optionsBuilder.EnableRetryOnFailure();
            });

            optionsBuilder.EnableSensitiveDataLogging().LogTo(Console.WriteLine);

            optionsBuilder.ReplaceService<IValueConverterSelector, StronglyTypedIdValueConverterSelector>();
            base.OnConfiguring(optionsBuilder);
        }

        public sealed override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            SetDatetime();
            return SaveChangesAsync(acceptAllChangesOnSuccess: true, cancellationToken);
        }

        private void SetDatetime()
        {
            var entries = ChangeTracker
                               .Entries()
                               .Where(e => IsInheritedFromTypedIdValueBase(e.Entity.GetType()) && (
                       e.State == EntityState.Added
                       || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                var entity = entityEntry.Entity;

                var updatedAtProperty = entity.GetType().GetProperty(nameof(Entity<TypedIdValueBase>.UpdatedAt));
                if (updatedAtProperty != null)
                {
                    updatedAtProperty.SetValue(entity, DateTime.Now);
                }

                var createdAtProperty = entity.GetType().GetProperty(nameof(Entity<TypedIdValueBase>.CreatedAt));
                if (createdAtProperty != null)
                {
                    if (entityEntry.State == EntityState.Added)
                    {
                        createdAtProperty.SetValue(entity, DateTime.Now);
                    }
                }
            }
        }

        static bool IsInheritedFromTypedIdValueBase(Type type)
        {
            Type? genericArgumentType = type.BaseType?.GetGenericArguments().FirstOrDefault();

            bool inheritsFromTypedIdValueBase = genericArgumentType != null && typeof(TypedIdValueBase).IsAssignableFrom(genericArgumentType);
            return inheritsFromTypedIdValueBase;
        }
    }
}