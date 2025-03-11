using AutoMapper;
using Reservation.Booking.Dtos.CategoryDtos;
using Reservation.Booking.Dtos.RoomDtos;
using Reservation.Booking.Entities;

namespace Reservation.Booking.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, GetByIdCategoryDto>().ReverseMap();

            CreateMap<Room, ResultRoomDto>().ReverseMap();
            CreateMap<Room, UpdateRoomDto>().ReverseMap();
            CreateMap<Room, CreateRoomDto>().ReverseMap();
            CreateMap<Room, GetByIdRoomDto>().ReverseMap();
        }
    }
}
