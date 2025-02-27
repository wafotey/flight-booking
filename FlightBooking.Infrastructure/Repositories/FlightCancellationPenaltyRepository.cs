using FlightBooking.Domain.Aggregates.FlightCancellationPenaltyAggregate;
using Microsoft.EntityFrameworkCore;

namespace FlightBooking.Infrastructure.Repositories
{
    public class FlightCancellationPenaltyRepository: IFlightCancellationPenaltyRepository
    {
        private readonly DbContext _context;

        public FlightCancellationPenaltyRepository(DbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Add(FlightCancellationPenalty flightCancellationPenalty)
        {
            _context.Set<FlightCancellationPenalty>().Add(flightCancellationPenalty);
        }

        public void Update(FlightCancellationPenalty flightCancellationPenalty)
        {
            _context.Set<FlightCancellationPenalty>().Update(flightCancellationPenalty);
        }

        public async Task<FlightCancellationPenalty?> GetByIdAsync(FlightCancellationPenaltyId flightCancellationPenaltyId, CancellationToken cancellationToken = default(CancellationToken))
        {
            return await _context.Set<FlightCancellationPenalty>()
                .FirstOrDefaultAsync(c => c.Id.Equals(flightCancellationPenaltyId), cancellationToken);
        }
    }
}