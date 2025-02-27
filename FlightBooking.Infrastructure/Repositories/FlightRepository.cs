using FlightBooking.Domain.Aggregates.FlightAggregate;
using Microsoft.EntityFrameworkCore;

namespace FlightBooking.Infrastructure.Repositories
{
    public class FlightRepository : IFlightRepository
    {
        private readonly DbContext _context;
        public FlightRepository(DbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void Add(Flight flight)
        {
            _context.Set<Flight>().Add(flight);
        }
        public void Update(Flight flight)
        {
            _context.Set<Flight>().Update(flight);
        }
        public async Task<Flight?> GetByIdAsync(FlightId flightId, CancellationToken cancellationToken = default(CancellationToken))
        {
            return await _context.Set<Flight>()
                .FirstOrDefaultAsync(c => c.Id.Equals(flightId), cancellationToken);
        }
    }
}