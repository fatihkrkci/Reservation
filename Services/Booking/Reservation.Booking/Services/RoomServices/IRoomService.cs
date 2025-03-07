using Reservation.Booking.Dtos.CategoryDtos;
using Reservation.Booking.Dtos.RoomDtos;

namespace Reservation.Booking.Services.RoomServices
{
    public interface IRoomService
    {
        Task<List<ResultRoomDto>> GetAllRoomAsync();
        Task CreateRoomAsync(CreateRoomDto createRoomDto);
        Task UpdateRoomAsync(UpdateRoomDto updateRoomDto);
        Task DeleteRoomAsync(string id);
        Task<GetByIdRoomDto> GetRoomByIdAsync(string id);
    }
}
