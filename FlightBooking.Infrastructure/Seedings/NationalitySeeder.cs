using FlightBooking.Domain.SharedKennel;
using FlightBooking.Domain.SharedKennel.Enumerations;
using Microsoft.EntityFrameworkCore;

namespace FlightBooking.Infrastructure.Seedings
{
    public class NationalitySeeder : IDatabaseSeeder
    {
        private readonly DbContext _context;
        public NationalitySeeder(DbContext context)
        {
            _context = context?? throw new ArgumentNullException(nameof(context));
        }
        public void Seed()
        {
            if (!_context.Set<Nationality>().Any())
            {
                _context.Set<Nationality>().AddRange(Enumeration.GetAll<Nationality>());
            }
        }
    }
}