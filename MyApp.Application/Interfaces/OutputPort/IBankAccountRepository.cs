using MyApp.Domain.Entities;

namespace MyApp.Application.Interfaces.OutputPort
{
    public interface IBankAccountRepository
    {
        Task<BankAccount?> GetByIdAsync(int accountId);
        Task SaveAsync(BankAccount account);
    }
}
