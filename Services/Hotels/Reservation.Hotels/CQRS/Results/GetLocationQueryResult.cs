namespace Reservation.Hotels.CQRS.Results
{
    public class GetLocationQueryResult
    {
        public int LocationId { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Country { get; set; }
    }
}
