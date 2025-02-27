using FlightBooking.Domain.SharedKennel;
using FlightBooking.Domain.SharedKennel.Enumerations;
using Microsoft.EntityFrameworkCore;

namespace FlightBooking.Infrastructure.Seedings
{
    public class MonthSeeder : IDatabaseSeeder
    {
        private readonly DbContext _context;
        public MonthSeeder(DbContext context)
        {
            _context = context?? throw new ArgumentNullException(nameof(context));
        }
        public void Seed()
        {
            if (!_context.Set<Month>().Any())
            {
                _context.Set<Month>().AddRange(Enumeration.GetAll<Month>());
            }
        }
    }
}