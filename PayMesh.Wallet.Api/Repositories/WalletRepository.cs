using Microsoft.AspNetCore.Http.HttpResults;
using PayMesh.Wallet.Api.Data;
using PayMesh.Wallet.Api.Entities;
using PayMesh.Wallet.Api.Entities.Enums;

public class WalletRepository : IWalletRepository
{

    private readonly WalletDbContext _dbContext;

    public WalletRepository(WalletDbContext pDbContext)
    {
        _dbContext = pDbContext ?? throw new ArgumentNullException(nameof(pDbContext));
    }

    public Task AddWalletAsync(WalletEntity wallet)
    {
        _dbContext.Wallets.Add(wallet);

        return _dbContext.SaveChangesAsync();
    }

    public Task DeleteWalletAsync(WalletEntity wallet)
    {

    
        // if(wallet.Transactions.Any(t => t.Status == TransactionStatus.Pending))
        // {
        //     throw new InvalidOperationException("Cannot delete a wallet with pending transactions.");
        // }

        wallet.Close();

        return _dbContext.SaveChangesAsync();
    }

    public Task<IEnumerable<WalletEntity>> GetAllWalletsAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<WalletEntity> GetWalletByIdAsync(Guid walletId)
    {
        var wallet = await _dbContext.Wallets.FindAsync(walletId);

        return wallet ?? throw new KeyNotFoundException($"Wallet with ID {walletId} not found.");
    }

    public Task UpdateWalletAsync(WalletEntity wallet)
    {
        _dbContext.Wallets.Update(wallet);

        return _dbContext.SaveChangesAsync();
    }
}