using MyApp.Application.Interfaces.OutputPort;
using MyApp.Domain.Entities;

namespace MyApp.Infrastructure.DriverAdapter
{
    public class BankAccountRepositoryAdapter : IBankAccountRepository
    {
        readonly FakeBankAccountRepository _repository;
        public BankAccountRepositoryAdapter(FakeBankAccountRepository repository)
        {
            _repository = repository;
        }
        public Task<BankAccount?> GetByIdAsync(int accountId)
        {
            return _repository.GetByIdAsync(accountId);
        }

        public Task SaveAsync(BankAccount account)
        {
            return _repository.SaveAsync(account);
        }
    }
}
