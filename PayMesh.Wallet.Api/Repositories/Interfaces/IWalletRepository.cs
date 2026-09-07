using PayMesh.Wallet.Api.Entities;

public interface IWalletRepository
{
    Task<WalletEntity> GetWalletByIdAsync(Guid walletId);
    Task<IEnumerable<WalletEntity>> GetAllWalletsAsync();
    Task AddWalletAsync(WalletEntity wallet);
    Task UpdateWalletAsync(WalletEntity wallet);
    Task DeleteWalletAsync(WalletEntity wallet);
}