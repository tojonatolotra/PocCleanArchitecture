using MyApp.Application.DTOs;
using MyApp.Application.Interfaces.InputPort;

namespace MyApp.Api.DrivingAdapter
{
    public class WithdrawMoneyControllerAdapter
    {
        private readonly IWithdrawMoneyUseCase _inputPort;

        public WithdrawMoneyControllerAdapter(IWithdrawMoneyUseCase inputPort)
        {
            _inputPort = inputPort;
        }

        public async Task<WithdrawMoneyResponse> WithdrawAsync(int accountId, decimal amount)
        {
            var request = new WithdrawMoneyRequest(accountId, amount);
            return await _inputPort.Handle(request);
        }
    }
}
