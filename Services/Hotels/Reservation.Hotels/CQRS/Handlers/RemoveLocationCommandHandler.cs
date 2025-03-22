using Reservation.Hotels.Context;
using Reservation.Hotels.CQRS.Commands;

namespace Reservation.Hotels.CQRS.Handlers
{
    public class RemoveLocationCommandHandler
    {
        private readonly HotelContext _context;

        public RemoveLocationCommandHandler(HotelContext context)
        {
            _context = context;
        }

        public void Handle(RemoveCommandLocation command)
        {
            var value = _context.Locations.Find(command.LocationId);
            _context.Locations.Remove(value);
            _context.SaveChanges();
        }
    }
}
