using FlightBooking.Domain.SharedKennel;
using FlightBooking.Domain.SharedKennel.Enumerations;

namespace FlightBooking.Infrastructure.Seedings
{
    public class MonthSeeder : IDatabaseSeeder
    {
        private readonly BookingDbContext _context;
        public MonthSeeder(BookingDbContext context)
        {
            _context = context?? throw new ArgumentNullException(nameof(context));
        }
        public void Seed()
        {
            if (!_context.Set<Month>().Any())
            {
                _context.Set<Month>().AddRange(Enumeration.GetAll<Month>());
            }
        }
    }
}