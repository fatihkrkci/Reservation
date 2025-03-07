using AutoMapper;
using MongoDB.Driver;
using Reservation.Booking.Dtos.CategoryDtos;
using Reservation.Booking.Dtos.RoomDtos;
using Reservation.Booking.Entities;
using Reservation.Booking.Settings;

namespace Reservation.Booking.Services.RoomServices
{
    public class RoomService : IRoomService
    {
        private readonly IMongoCollection<Room> _roomCollection;
        private readonly IMapper _mapper;

        public RoomService(IMapper mapper, IDatabaseSetting _databaseSetting)
        {
            var client = new MongoClient(_databaseSetting.ConnectionString);
            var database = client.GetDatabase(_databaseSetting.DatabaseName);
            _roomCollection = database.GetCollection<Room>(_databaseSetting.RoomCollectionName);
            _mapper = mapper;
        }

        public async Task CreateRoomAsync(CreateRoomDto createRoomDto)
        {
            var value = _mapper.Map<Room>(createRoomDto);
            await _roomCollection.InsertOneAsync(value);
        }

        public async Task DeleteRoomAsync(string id)
        {
            await _roomCollection.DeleteOneAsync(x => x.RoomId == id);
        }

        public async Task<List<ResultRoomDto>> GetAllRoomAsync()
        {
            var values = await _roomCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultRoomDto>>(values);
        }

        public async Task<GetByIdRoomDto> GetRoomByIdAsync(string id)
        {
            var values = await _roomCollection.Find(x => x.RoomId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetByIdRoomDto>(values);
        }

        public async Task UpdateRoomAsync(UpdateRoomDto updateRoomDto)
        {
            var values = _mapper.Map<Room>(updateRoomDto);
            await _roomCollection.FindOneAndReplaceAsync(x => x.RoomId == updateRoomDto.RoomId, values);
        }
    }
}
