using FlightBooking.Domain.SharedKennel;
using FlightBooking.Domain.SharedKennel.Enumerations;

namespace FlightBooking.Infrastructure.Seedings
{
    public class CurrencySeeder : IDatabaseSeeder
    {
        private readonly BookingDbContext _context;
        public CurrencySeeder(BookingDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void Seed()
        {
            if (!_context.Set<Currency>().Any())
            {
                _context.Set<Currency>().AddRange(Enumeration.GetAll<Currency>());
            }
        }
    }
}