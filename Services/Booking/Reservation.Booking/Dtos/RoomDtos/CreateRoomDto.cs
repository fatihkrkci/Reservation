namespace Reservation.Booking.Dtos.RoomDtos
{
    public class CreateRoomDto
    {
        public string RoomNumber { get; set; }
        public int Capacity { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
