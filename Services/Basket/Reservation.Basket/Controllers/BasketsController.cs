using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservation.Basket.Dtos;
using Reservation.Basket.LoginServices;
using Reservation.Basket.Services;

namespace Reservation.Basket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
        private readonly IBasketService _basketService;
        private readonly ILoginService _loginService;

        public BasketsController(IBasketService basketService, ILoginService loginService)
        {
            _basketService = basketService;
            _loginService = loginService;
        }

        [HttpGet]
        public async Task<IActionResult> GetMyBasketDetail()
        {
            var values = await _basketService.GetBasket(_loginService.GetUserId);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> SaveMyBasket(BasketTotalDto basketTotalDto)
        {
            basketTotalDto.UserId = _loginService.GetUserId;
            await _basketService.SaveBasket(basketTotalDto);
            return Ok("Sepetteki Değişiklikler Kaydedildi!");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBasket()
        {
            await _basketService.DeleteBasket(_loginService.GetUserId);
            return Ok("Sepet Başarıyla Silindi!");
        }
    }
}
