namespace Reservation.Hotels.CQRS.Results
{
    public class GetByIdLocationQueryResult
    {
        public int LocationId { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Country { get; set; }
    }
}
