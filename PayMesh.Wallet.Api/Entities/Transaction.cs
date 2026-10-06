using PayMesh.Wallet.Api.Entities.Enums;

namespace PayMesh.Wallet.Api.Entities;

public class TransactionEntity
{
    public Guid Id { get; set; }

    public Guid WalletId { get; set; }

    public decimal Amount { get; set; }
    
    public TransactionType Type { get; set; }

    public DateTime CreatedAt { get; set; }

    public TransactionStatus Status { get; private set; } = TransactionStatus.Pending;
   
    public WalletEntity Wallet { get; set; } = null!;

}

