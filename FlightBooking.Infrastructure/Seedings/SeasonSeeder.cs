using FlightBooking.Domain.SharedKennel;
using FlightBooking.Domain.SharedKennel.Enumerations;
using Microsoft.EntityFrameworkCore;

namespace FlightBooking.Infrastructure.Seedings
{
    public class SeasonSeeder : IDatabaseSeeder
    {
        private readonly DbContext _context;
        public SeasonSeeder(DbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void Seed()
        {
            if (!_context.Set<Season>().Any())
            {
                _context.Set<Season>().AddRange(Enumeration.GetAll<Season>());
            }
        }
    }
}