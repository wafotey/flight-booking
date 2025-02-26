namespace FlightBooking.Domain.Aggregates.FlightCancellationPenaltySettingsAggregate
{
    public interface IFlightCanellationPenaltySettingsRepository
    {
         void Add(FlightCancellationPenaltySettings flightCancellationPenaltySettings);
         void Update(FlightCancellationPenaltySettings flightCancellationPenaltySettings);
         Task<FlightCancellationPenaltySettings?> GetByIdAsync(FlightCancellationPenaltySettingsId flightCancellationPenaltySettingsId, CancellationToken cancellationToken = default(CancellationToken));
    }
}