namespace FlightBooking.Domain.Aggregates.NoShowPenaltyAggregate
{
    public interface INoShowPenaltyRepository
    {
         void Add(NoShowPenalty noShowPenalty);
         void Update(NoShowPenalty noShowPenalty);
         Task<NoShowPenalty?> GetByIdAsync(NoShowPenaltyId noShowPenaltyId, CancellationToken cancellationToken = default(CancellationToken));
    }
}