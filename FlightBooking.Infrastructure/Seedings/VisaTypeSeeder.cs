using FlightBooking.Domain.SharedKennel;
using FlightBooking.Domain.SharedKennel.Enumerations;
using Microsoft.EntityFrameworkCore;

namespace FlightBooking.Infrastructure.Seedings
{
    public class VisaTypeSeeder : IDatabaseSeeder
    {
        private readonly DbContext _context;
        public VisaTypeSeeder(DbContext context)
        {
            _context = context?? throw new ArgumentNullException(nameof(context));
        }
        public void Seed()
        {
            if (!_context.Set<VisaType>().Any())
                _context.Set<VisaType>().AddRange(Enumeration.GetAll<VisaType>());
        }
    }
}
   