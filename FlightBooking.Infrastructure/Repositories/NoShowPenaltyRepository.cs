using FlightBooking.Domain.Aggregates.NoShowPenaltyAggregate;
using Microsoft.EntityFrameworkCore;

namespace FlightBooking.Infrastructure.Repositories
{
    public class NoShowPenaltyRepository : INoShowPenaltyRepository
    {
        private readonly DbContext _context;
        public NoShowPenaltyRepository(DbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void Add(NoShowPenalty noShowPenalty)
        {
            _context.Set<NoShowPenalty>().Add(noShowPenalty);
        }
        public void Update(NoShowPenalty noShowPenalty)
        {
            _context.Set<NoShowPenalty>().Update(noShowPenalty);
        }
        public async Task<NoShowPenalty?> GetByIdAsync(NoShowPenaltyId noShowPenaltyId, CancellationToken cancellationToken = default(CancellationToken))
        {
            return await _context.Set<NoShowPenalty>()
                .FirstOrDefaultAsync(c => c.Id.Equals(noShowPenaltyId), cancellationToken);
        }
    }
}