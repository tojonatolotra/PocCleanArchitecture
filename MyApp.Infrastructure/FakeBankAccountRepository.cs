using MyApp.Domain.Entities;

namespace MyApp.Infrastructure
{
    public class FakeBankAccountRepository
    {
        private readonly Dictionary<int, BankAccount> _store = new();

        public FakeBankAccountRepository()
        {
            foreach (var i in Enumerable.Range(1, 10))
            {
                var account = new BankAccount(i, Random.Shared.Next(100, 5000));
                _store[i] = account;
            }
        }

        public Task<BankAccount?> GetByIdAsync(int accountId)
        {
            if (!_store.TryGetValue(accountId, out var account))
            {
                return Task.FromResult<BankAccount?>(null);
            }

            return Task.FromResult<BankAccount?>(account);
        }

        public Task SaveAsync(BankAccount account)
        {
            _store[account.Id] = account;
            return Task.CompletedTask;
        }
    }
}
