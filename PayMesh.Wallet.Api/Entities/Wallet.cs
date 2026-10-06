using PayMesh.Wallet.Api.Entities.Enums;

namespace PayMesh.Wallet.Api.Entities;

public class WalletEntity
{
    public Guid Id { get; set; }

    public decimal Balance { get; set; }

    public string Currency { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }
    
    public DateTime UpdatedAt { get; set; }

    public int OwnerId { get; set; }

    public WalletStatus Status { get; private set; } = WalletStatus.Active;

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

        if(pAmount > Balance)
        throw new ArgumentException("Insufficient funds for withdrawal.");

        Balance -= pAmount;
    }

    public void Close()
    {
        if (Balance != 0)
            throw new InvalidOperationException(
                "A wallet with balance cannot be closed.");

        if (Status == WalletStatus.Inactive)
            throw new InvalidOperationException(
                "Wallet is already closed.");

        // if(wallet.Transactions.Any(t => t.Status == TransactionStatus.Pending))
        // {
        //     throw new InvalidOperationException("Cannot delete a wallet with pending transactions.");
        // }

        // tava tentando decidir se deveria estar na entidade ou no service, mas vai ficar na entidade pq nas minhas pesquisas o ideal é estar private set na entidade pra
        // não permitir qualquer area do projeto modificar os valores
        Status = WalletStatus.Inactive;
        UpdatedAt = DateTime.UtcNow;
    }
}

