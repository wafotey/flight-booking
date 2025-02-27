using FlightBooking.Domain.SharedKennel;
using FlightBooking.Domain.SharedKennel.Enumerations;
using Microsoft.EntityFrameworkCore;

namespace FlightBooking.Infrastructure.Seedings
{
    public class FlyingStatusSeeder : IDatabaseSeeder
    {
        private readonly DbContext _context;
        public FlyingStatusSeeder(DbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void Seed()
        {
            if (!_context.Set<FlyingStatus>().Any())
            {
                _context.Set<FlyingStatus>().AddRange(Enumeration.GetAll<FlyingStatus>());
            }
        }
    }
}