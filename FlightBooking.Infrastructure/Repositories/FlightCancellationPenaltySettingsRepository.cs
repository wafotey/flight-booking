using FlightBooking.Domain.Aggregates.FlightCancellationPenaltySettingsAggregate;
using Microsoft.EntityFrameworkCore;

namespace FlightBooking.Infrastructure.Repositories
{
    public class FlightCancellationPenaltySettingsRepository: IFlightCanellationPenaltySettingsRepository
    {
        private readonly DbContext _context;
        public FlightCancellationPenaltySettingsRepository(DbContext context)
        {
            _context = context?? throw new ArgumentNullException(nameof(context));
        }
        
        public void Add(FlightCancellationPenaltySettings flightCancellationPenaltySettings)
        {
            _context.Set<FlightCancellationPenaltySettings>().Add(flightCancellationPenaltySettings);
        }

        public void Update(FlightCancellationPenaltySettings flightCancellationPenaltySettings)
        {
            _context.Set<FlightCancellationPenaltySettings>().Update(flightCancellationPenaltySettings);
        }
        public async Task<FlightCancellationPenaltySettings?> GetByIdAsync(FlightCancellationPenaltySettingsId flightCancellationPenaltySettingsId, CancellationToken cancellationToken = default(CancellationToken))
        {
            return await _context.Set<FlightCancellationPenaltySettings>()
                .FirstOrDefaultAsync(c => c.Id.Equals(flightCancellationPenaltySettingsId), cancellationToken);
        }
    }
}