using FlightBooking.Domain.SharedKennel;
using FlightBooking.Domain.SharedKennel.Enumerations;

namespace FlightBooking.Infrastructure.Seedings
{
    public class NationalitySeeder : IDatabaseSeeder
    {
        private readonly BookingDbContext _context;
        public NationalitySeeder(BookingDbContext context)
        {
            _context = context?? throw new ArgumentNullException(nameof(context));
        }
        public void Seed()
        {
            if (!_context.Set<Nationality>().Any())
            {
                _context.Set<Nationality>().AddRange(Enumeration.GetAll<Nationality>());
            }
        }
    }
}