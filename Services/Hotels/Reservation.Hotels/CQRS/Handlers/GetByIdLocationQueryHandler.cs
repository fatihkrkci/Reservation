using Reservation.Hotels.Context;
using Reservation.Hotels.CQRS.Queries;
using Reservation.Hotels.CQRS.Results;

namespace Reservation.Hotels.CQRS.Handlers
{
    public class GetByIdLocationQueryHandler
    {
        private readonly HotelContext _context;

        public GetByIdLocationQueryHandler(HotelContext context)
        {
            _context = context;
        }

        public GetByIdLocationQueryResult Handle(GetByIdLocationQuery query)
        {
            var value = _context.Locations.Find(query.LocationId);
            return new GetByIdLocationQueryResult
            {
                LocationId = value.LocationId,
                Country = value.Country,
                District = value.District,
                City = value.City
            };
        }
    }
}
