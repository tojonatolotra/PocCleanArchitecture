using MyApp.Application.DTOs;

namespace MyApp.Application.Interfaces.InputPort
{
    public interface IWithdrawMoneyUseCase
    {
        Task<WithdrawMoneyResponse> Handle(WithdrawMoneyRequest request);
    }
}
