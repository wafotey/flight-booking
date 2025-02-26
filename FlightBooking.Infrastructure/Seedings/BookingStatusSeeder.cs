using FlightBooking.Domain.Aggregates.BookingAggregate;
using FlightBooking.Domain.SharedKennel;

namespace FlightBooking.Infrastructure.Seedings
{
    public class BookingStatusSeeder : IDatabaseSeeder
    {
        private readonly BookingDbContext _context;
        public BookingStatusSeeder(BookingDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void Seed()
        {
            if (!_context.Set<BookingStatus>().Any())
            {
                _context.Set<BookingStatus>().AddRange(Enumeration.GetAll<BookingStatus>());
            }
        }
    }
}