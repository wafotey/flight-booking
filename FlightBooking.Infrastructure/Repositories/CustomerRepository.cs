using FlightBooking.Domain.Aggregates.CustomerAggregate;
using LanguageExt;
using Microsoft.EntityFrameworkCore;

namespace FlightBooking.Infrastructure.Repositories
{
    public class CustomerRepository: ICustomerRepository
    {
        private readonly DbContext _context;
        public CustomerRepository(DbContext context){
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void Add(Customer customer)
        {
            _context.Set<Customer>().Add(customer);
        }
        public void Update(Customer customer){
            _context.Set<Customer>().Update(customer);
        }
        public async Task<Option<Customer>> GetByIdAsync(CustomerId customerId, CancellationToken cancellationToken = default(CancellationToken))
        {
            return await _context.Set<Customer>()
                .FirstOrDefaultAsync(c => c.Id.Equals(customerId), cancellationToken);
        }
    }
}