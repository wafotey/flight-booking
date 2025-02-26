namespace FlightBooking.Domain.Aggregates.FlightCancellationPenaltyAggregate
{
    public interface IFlightCancellationPenaltyRepository
    {
         void Add(FlightCancellationPenalty flightCancellationPenalty);
         void Update(FlightCancellationPenalty flightCancellationPenalty);
        Task<FlightCancellationPenalty?> GetByIdAsync(FlightCancellationPenaltyId flightCancellationPenaltyId, CancellationToken cancellationToken = default(CancellationToken));
    }
}