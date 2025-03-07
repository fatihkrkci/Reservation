namespace Reservation.Booking.Settings
{
    public class DatabaseSetting : IDatabaseSetting
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string CategoryCollectionName { get; set; }
        public string RoomCollectionName { get; set; }
    }
}
