namespace Reservation.Hotels.CQRS.Queries
{
    public class GetByIdLocationQuery
    {
        public int LocationId { get; set; }

        public GetByIdLocationQuery(int locationId)
        {
            LocationId = locationId;
        }
    }
}
