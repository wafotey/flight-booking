using FlightBooking.Domain.Aggregates.NoShowPenaltySettingsAggregate;
using Microsoft.EntityFrameworkCore;

namespace FlightBooking.Infrastructure.Repositories
{
    public class NoShowPenaltySettingsRepository: INoShowPenaltySettingsRepository
    {
        private readonly DbContext _context;
        public NoShowPenaltySettingsRepository(DbContext context)
        {
            _context = context?? throw new ArgumentNullException(nameof(context));
        }
        public void Add(NoShowPenaltySettings noShowPenaltySettings)
        {
            _context.Set<NoShowPenaltySettings>().Add(noShowPenaltySettings);
        }
        public void Update(NoShowPenaltySettings noShowPenaltySettings)
        {
            _context.Set<NoShowPenaltySettings>().Update(noShowPenaltySettings);
        }
        public async Task<NoShowPenaltySettings?> GetByIdAsync(NoShowPenaltySettingsId noShowPenaltySettingsId, CancellationToken cancellationToken = default(CancellationToken))
        {
            return await _context.Set<NoShowPenaltySettings>()
                .FirstOrDefaultAsync(c => c.Id.Equals(noShowPenaltySettingsId), cancellationToken);
        }
    }
}