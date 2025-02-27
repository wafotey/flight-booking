using FlightBooking.Domain.Aggregates.BookingAggregate;
using FlightBooking.Domain.SharedKennel;
using Microsoft.EntityFrameworkCore;

namespace FlightBooking.Infrastructure.Seedings
{
    public class BookingStatusSeeder : IDatabaseSeeder
    {
        private readonly DbContext _context;
        public BookingStatusSeeder(DbContext context)
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