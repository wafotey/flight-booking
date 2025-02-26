using FlightBooking.Domain.SharedKennel;
using FlightBooking.Domain.SharedKennel.Enumerations;

namespace FlightBooking.Infrastructure.Seedings
{
    public class VisaTypeSeeder : IDatabaseSeeder
    {
        private readonly BookingDbContext _context;
        public VisaTypeSeeder(BookingDbContext context)
        {
            _context = context?? throw new ArgumentNullException(nameof(context));
        }
        public void Seed()
        {
            if (!_context.Set<VisaType>().Any())
                _context.Set<VisaType>().AddRange(Enumeration.GetAll<VisaType>());
        }
    }
}