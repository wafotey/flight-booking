
using FlightBooking.Domain.SharedKennel;
using FlightBooking.Domain.SharedKennel.Enumerations;
using Microsoft.EntityFrameworkCore;

namespace FlightBooking.Infrastructure.Seedings
{
    public class CountrySeeder : IDatabaseSeeder
    {
        private readonly DbContext _context;
        public CountrySeeder(DbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void Seed()
        {
            if (!_context.Set<Country>().Any())
            {
                _context.Set<Country>().AddRange(Enumeration.GetAll<Country>());
            }
        }
    }
}