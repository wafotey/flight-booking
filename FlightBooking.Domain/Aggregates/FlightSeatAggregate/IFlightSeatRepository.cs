namespace FlightBooking.Domain.Aggregates.FlightSeatAggregate
{
    public interface IFlightSeatRepository
    {
         void Add(FlightSeat flightSeat);
         void Update(FlightSeat flightSeat);
         Task<FlightSeat?> GetByIdAsync(FlightSeatId flightSeatId, CancellationToken cancellationToken = default(CancellationToken));
    }
}