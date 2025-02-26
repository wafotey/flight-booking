namespace FlightBooking.Domain.Aggregates.FlightAggregate
{
    public interface IFlightRepository
    {
         void Add(Flight flight);
         void Update(Flight flight);
         Task<Flight?> GetByIdAsync(FlightId flightId, CancellationToken cancellationToken = default(CancellationToken));
    }
}