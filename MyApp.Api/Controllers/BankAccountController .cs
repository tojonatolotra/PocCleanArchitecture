using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApp.Api.DrivingAdapter;
using MyApp.Application.DTOs;

namespace MyApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountController : ControllerBase
    {
        private readonly WithdrawMoneyControllerAdapter _adapter;

        public BankAccountController(WithdrawMoneyControllerAdapter adapter)
        {
            _adapter = adapter;
        }

        [HttpPost("withdraw")]
        public async Task<IActionResult> Withdraw([FromBody] WithdrawMoneyRequest dto)
        {
            var response = await _adapter.WithdrawAsync(dto.AccountId, dto.Amount);

            if (!response.Success)
                return BadRequest(response);

            return Ok(response);
        }
    }
}
