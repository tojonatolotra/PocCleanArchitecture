namespace MyApp.Application.DTOs
{
    public class WithdrawMoneyRequest
    {
        public int AccountId { get; }
        public decimal Amount { get; }

        public WithdrawMoneyRequest(int accountId, decimal amount)
        {
            AccountId = accountId;
            Amount = amount;
        }
    }
}
