using AutoMapper;
using Reservation.Review.Dtos;
using Reservation.Review.Entities;

namespace Reservation.Review.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<UserReview, ResultUserReviewDto>().ReverseMap();
            CreateMap<UserReview, GetByIdUserReviewDto>().ReverseMap();
            CreateMap<UserReview, CreateUserReviewDto>().ReverseMap();
            CreateMap<UserReview, UpdateUserReviewDto>().ReverseMap();
        }
    }
}
