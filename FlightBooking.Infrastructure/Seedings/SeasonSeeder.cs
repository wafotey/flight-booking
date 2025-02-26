using FlightBooking.Domain.SharedKennel;
using FlightBooking.Domain.SharedKennel.Enumerations;

namespace FlightBooking.Infrastructure.Seedings
{
    public class SeasonSeeder : IDatabaseSeeder
    {
        private readonly BookingDbContext _context;
        public SeasonSeeder(BookingDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void Seed()
        {
            if (!_context.Set<Season>().Any())
            {
                _context.Set<Season>().AddRange(Enumeration.GetAll<Season>());
            }
        }
    }
}