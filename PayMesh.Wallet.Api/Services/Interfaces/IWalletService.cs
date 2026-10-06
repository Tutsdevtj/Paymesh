using PayMesh.Wallet.Api.Entities;

public interface IWalletService
{
    Task<WalletEntity> GetWalletByIdAsync(Guid walletId);
    Task<IEnumerable<WalletEntity>> GetAllWalletsAsync(int pSkip, int pTake);
    Task AddWalletAsync(WalletEntity wallet);
    Task UpdateWalletAsync(WalletEntity wallet);
    Task DeleteWalletAsync(WalletEntity wallet);
}