using FlightBooking.Domain.Aggregates.BookingAggregate;
using Microsoft.EntityFrameworkCore;

namespace FlightBooking.Infrastructure.Repositories
{
    public class BookingRepository: IBookingRepository
    {
        private readonly BookingDbContext _context;
        public BookingRepository(BookingDbContext context)
        {
            _context = context?? throw new ArgumentNullException(nameof(context));
        }
        public void Add(Booking booking)
        {
            _context.Set<Booking>().Add(booking);
        }
        public void Update(Booking booking)
        {
            _context.Set<Booking>().Update(booking);
        }
        public async Task<Booking?> GetByIdAsync(BookingId bookingId, CancellationToken cancellationToken = default(CancellationToken))
        {
            return await _context.Set<Booking>()
                .FirstOrDefaultAsync(c => c.Id.Equals(bookingId), cancellationToken);
        }
    }
}