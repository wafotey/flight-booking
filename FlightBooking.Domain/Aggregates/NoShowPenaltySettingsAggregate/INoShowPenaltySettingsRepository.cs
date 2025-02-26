namespace FlightBooking.Domain.Aggregates.NoShowPenaltySettingsAggregate
{
    public interface INoShowPenaltySettingsRepository
    {
         void Add(NoShowPenaltySettings noShowPenaltySettings);
         void Update(NoShowPenaltySettings noShowPenaltySettings);
         Task<NoShowPenaltySettings?> GetByIdAsync(NoShowPenaltySettingsId noShowPenaltySettingsId, CancellationToken cancellationToken = default(CancellationToken));
    }
}