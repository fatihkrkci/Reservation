using Reservation.Hotels.Context;
using Reservation.Hotels.CQRS.Commands;
using Reservation.Hotels.Entities;

namespace Reservation.Hotels.CQRS.Handlers
{
    public class CreateLocationCommandHandler
    {
        private readonly HotelContext _context;

        public CreateLocationCommandHandler(HotelContext context)
        {
            _context = context;
        }

        public void Handle(CreateCommandLocation command)
        {
            _context.Locations.Add(new Location
            {
                Country = command.Country,
                City = command.City,
                District = command.District
            });
            _context.SaveChanges();
        }
    }
}
