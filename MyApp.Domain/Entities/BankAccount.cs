namespace MyApp.Domain.Entities
{
    public class BankAccount
    {
        public int Id { get; private set; }
        public decimal Balance { get; private set; }

        public BankAccount(int id, decimal initialBalance)
        {
            if (initialBalance < 0)
                throw new ArgumentException("Le solde initial ne peut pas être négatif.");

            Id = id;
            Balance = initialBalance;
        }

        public bool CanWithdraw(decimal amount)
        {
            return amount <= Balance;
        }

        public void Withdraw(decimal amount)
        {
            if (!CanWithdraw(amount))
                throw new InvalidOperationException("Fonds insuffisants pour le retrait.");

            Balance -= amount;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Le montant du dépôt doit être positif.");

            Balance += amount;
        }
    }
}
