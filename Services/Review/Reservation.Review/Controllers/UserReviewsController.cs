using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservation.Review.Dtos;
using Reservation.Review.Services;

namespace Reservation.Review.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserReviewsController : ControllerBase
    {
        private readonly IUserReviewService _userReviewService;

        public UserReviewsController(IUserReviewService userReviewService)
        {
            _userReviewService = userReviewService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUserReview()
        {
            var value = await _userReviewService.GetAllUserReviewAsync();
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUserReview(CreateUserReviewDto createUserReviewDto)
        {
            await _userReviewService.CreateUserReviewAsync(createUserReviewDto);
            return Ok("Ekleme İşlemi Başarılı!");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUserReview(UpdateUserReviewDto updateUserReviewDto)
        {
            await _userReviewService.UpdateUserReviewAsync(updateUserReviewDto);
            return Ok("Güncelleme İşlemi Başarılı!");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUserReview(int id)
        {
            await _userReviewService.DeleteUserReviewAsync(id);
            return Ok("Silme İşlemi Başarılı!");
        }
    }
}