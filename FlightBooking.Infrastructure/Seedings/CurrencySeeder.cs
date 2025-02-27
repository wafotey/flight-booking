using FlightBooking.Domain.SharedKennel;
using FlightBooking.Domain.SharedKennel.Enumerations;
using Microsoft.EntityFrameworkCore;

namespace FlightBooking.Infrastructure.Seedings
{
    public class CurrencySeeder : IDatabaseSeeder
    {
        private readonly DbContext _context;
        public CurrencySeeder(DbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void Seed()
        {
            if (!_context.Set<Currency>().Any())
            {
                _context.Set<Currency>().AddRange(Enumeration.GetAll<Currency>());
            }
        }
    }
}