namespace FlightBooking.Domain.SharedKennel.Enumerations
{
    public class VisaType : Enumeration
    {
        public static VisaType Tourist = new VisaType(1, nameof(Tourist));
        public static VisaType Business = new VisaType(2, nameof(Business));
        public static VisaType Work = new VisaType(3, nameof(Work));
        public static VisaType F1 = new VisaType(4, nameof(F1));

        public VisaType(int id, string name) : base(id, name)
        {
        }
    }
}