namespace Reservation.Booking.Entities
{
    public class Room
    {
        public string RoomId { get; set; }
        public string RoomNumber { get; set; }
        public int Capacity { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
