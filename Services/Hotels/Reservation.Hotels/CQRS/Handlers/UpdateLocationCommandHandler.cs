using Reservation.Hotels.Context;
using Reservation.Hotels.CQRS.Commands;

namespace Reservation.Hotels.CQRS.Handlers
{
    public class UpdateLocationCommandHandler
    {
        private readonly HotelContext _context;

        public UpdateLocationCommandHandler(HotelContext context)
        {
            _context = context;
        }

        public void Handle(UpdateCommandLocation command)
        {
            var value = _context.Locations.Find(command.LocationId);
            value.City = command.City;
            value.Country = command.Country;
            value.District = command.District;
            _context.SaveChanges();
        }
    }
}
