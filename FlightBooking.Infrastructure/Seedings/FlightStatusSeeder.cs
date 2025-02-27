using FlightBooking.Domain.Aggregates.FlightAggregate;
using FlightBooking.Domain.SharedKennel;
using Microsoft.EntityFrameworkCore;

namespace FlightBooking.Infrastructure.Seedings
{
    public class FlightStatusSeeder : IDatabaseSeeder
    {
        private readonly DbContext _context;
        public FlightStatusSeeder(DbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void Seed()
        {
            if (!_context.Set<FlightStatus>().Any())
            {
                _context.Set<FlightStatus>().AddRange(Enumeration.GetAll<FlightStatus>());
            }
        }
    }
}