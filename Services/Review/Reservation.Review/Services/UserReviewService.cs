using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Reservation.Review.Context;
using Reservation.Review.Dtos;
using Reservation.Review.Entities;

namespace Reservation.Review.Services
{
    public class UserReviewService : IUserReviewService
    {
        private readonly ReviewContext _context;
        private readonly IMapper _mapper;

        public UserReviewService(ReviewContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateUserReviewAsync(CreateUserReviewDto createUserReviewDto)
        {
            var value = _mapper.Map<UserReview>(createUserReviewDto);
            await _context.UserReviews.AddAsync(value);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUserReviewAsync(int id)
        {
            var value = await _context.UserReviews.FindAsync(id);
            _context.UserReviews.Remove(value);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ResultUserReviewDto>> GetAllUserReviewAsync()
        {
            var values = await _context.UserReviews.ToListAsync();
            return _mapper.Map<List<ResultUserReviewDto>>(values);
        }

        public async Task<GetByIdUserReviewDto> GetByIdUserReviewAsync(int id)
        {
            var value = await _context.UserReviews.FindAsync(id);
            return _mapper.Map<GetByIdUserReviewDto>(value);
        }

        public async Task UpdateUserReviewAsync(UpdateUserReviewDto updateUserReviewDto)
        {
            var value = _mapper.Map<UserReview>(updateUserReviewDto);
            _context.UserReviews.Update(value);
            await _context.SaveChangesAsync();
        }
    }
}
