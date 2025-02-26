using FlightBooking.Domain.Aggregates.FlightAggregate;
using FlightBooking.Domain.SharedKennel;

namespace FlightBooking.Infrastructure.Seedings
{
    public class FlightStatusSeeder : IDatabaseSeeder
    {
        private readonly BookingDbContext _context;
        public FlightStatusSeeder(BookingDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void Seed()
        {
            if (!_context.Set<FlightStatus>().Any())
            {
                _context.Set<FlightStatus>().AddRange(Enumeration.GetAll<FlightStatus>());
            }
        }
    }
}