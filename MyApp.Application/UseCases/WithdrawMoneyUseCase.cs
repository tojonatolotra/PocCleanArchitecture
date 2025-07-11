using MyApp.Application.DTOs;
using MyApp.Application.Interfaces.InputPort;
using MyApp.Application.Interfaces.OutputPort;

namespace MyApp.Application.UseCases
{
    public class WithdrawMoneyUseCase : IWithdrawMoneyUseCase
    {
        private readonly IBankAccountRepository _repository;

        public WithdrawMoneyUseCase(IBankAccountRepository repository)
        {
            _repository = repository;
        }

        public async Task<WithdrawMoneyResponse> Handle(WithdrawMoneyRequest request)
        {
            var account = await _repository.GetByIdAsync(request.AccountId);

            if (account == null)
            {
                return new WithdrawMoneyResponse(false, "Compte introuvable");
            }

            if (!account.CanWithdraw(request.Amount))
            {
                return new WithdrawMoneyResponse(false, "Solde insuffisant");
            }

            account.Withdraw(request.Amount);

            await _repository.SaveAsync(account);

            return new WithdrawMoneyResponse(true, "Retrait effectué avec succès");
        }
    }
}
