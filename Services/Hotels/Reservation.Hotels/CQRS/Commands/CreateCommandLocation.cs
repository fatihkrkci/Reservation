namespace Reservation.Hotels.CQRS.Commands
{
    public class CreateCommandLocation
    {
        public string City { get; set; }
        public string District { get; set; }
        public string Country { get; set; }
    }
}
