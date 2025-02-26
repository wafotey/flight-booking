using FlightBooking.Domain.Aggregates.FlightSeatAggregate;
using Microsoft.EntityFrameworkCore;

namespace FlightBooking.Infrastructure.Repositories
{
    public class FlightSeatRepository: IFlightSeatRepository
    {
        private readonly BookingDbContext _context;
        public FlightSeatRepository(BookingDbContext context)
        {
            _context = context?? throw new ArgumentNullException(nameof(context));
        }
        public void Add(FlightSeat flightSeat)
        {
            _context.Set<FlightSeat>().Add(flightSeat);
        }

        public void Update(FlightSeat flightSeat)
        {
            _context.Set<FlightSeat>().Update(flightSeat);
        }
        public async Task<FlightSeat?> GetByIdAsync(FlightSeatId flightSeatId, CancellationToken cancellationToken = default(CancellationToken))
        {
            return await _context.Set<FlightSeat>()
                .FirstOrDefaultAsync(c => c.Id.Equals(flightSeatId), cancellationToken);
        }
    }
}