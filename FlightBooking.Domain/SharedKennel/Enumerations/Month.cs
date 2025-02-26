using System;
using System.Linq;

namespace FlightBooking.Domain.SharedKennel.Enumerations
{
    public class Month : Enumeration
    {
        public static Month January = new Month(1, nameof(January));
        public static Month February = new Month(2, nameof(February));
        public static Month March = new Month(3, nameof(March));
        public static Month April = new Month(4, nameof(April));
        public static Month May = new Month(5, nameof(May));
        public static Month June = new Month(6, nameof(June));
        public static Month July = new Month(7, nameof(July));
        public static Month August = new Month(8, nameof(August));
        public static Month September = new Month(9, nameof(September));
        public static Month October = new Month(10, nameof(October));
        public static Month November = new Month(11, nameof(November));
        public static Month December = new Month(12, nameof(December));

        public Month(int id, string name) : base(id, name)
        {
        }

        public static Month GetCurrentMonth()
        {
            var currentMonthNumber = DateTime.Now.Month;
            return GetAll<Month>().FirstOrDefault(m => m.Id == currentMonthNumber) ?? January;
        }

        public bool IsPeakSeason()
        {
            return this == June || this == July || this == August || this == December;
        }
    }
}