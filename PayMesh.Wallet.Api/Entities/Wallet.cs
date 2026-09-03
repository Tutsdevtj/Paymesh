public class Wallet
{
    public int Id { get; set; }

    public decimal Balance { get; set; }

    public string Currency { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }

    public int OwnerId { get; set; }

    public void Deposit(decimal pAmount)
    {
    if(pAmount <= 0)
    throw new ArgumentException("Deposit amount must be greater than zero.");

    Balance += pAmount;
    }

    public void Withdraw(decimal pAmount)
    {
        if(pAmount <= 0)
        throw new ArgumentException("Withdrawal amount must be greater than zero.");

        if(pAmount >= Balance)
        throw new ArgumentException("Insufficient funds for withdrawal.");

        Balance -= pAmount;
    }
}

