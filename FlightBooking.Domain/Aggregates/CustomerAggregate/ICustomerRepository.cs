using LanguageExt;
namespace FlightBooking.Domain.Aggregates.CustomerAggregate
{
    public interface ICustomerRepository
    {
         void Add(Customer customer);
         void Update(Customer customer);
         Task<Option<Customer>> GetByIdAsync(
            CustomerId customerId,
            CancellationToken cancellationToken = default(CancellationToken));
    }
}