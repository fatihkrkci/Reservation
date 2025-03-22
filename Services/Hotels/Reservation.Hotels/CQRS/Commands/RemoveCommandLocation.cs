namespace Reservation.Hotels.CQRS.Commands
{
    public class RemoveCommandLocation
    {
        public int LocationId { get; set; }

        public RemoveCommandLocation(int locationId)
        {
            LocationId = locationId;
        }
    }
}
