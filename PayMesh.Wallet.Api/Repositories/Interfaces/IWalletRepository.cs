using PayMesh.Wallet.Api.Entities;

public interface IWalletRepository
{
    Task<WalletEntity> GetWalletByIdAsync(Guid walletId);
    Task<IEnumerable<WalletEntity>> GetAllWalletsAsync(int pTop, int pTake);
    Task AddWalletAsync(WalletEntity wallet);
    Task UpdateWalletAsync(WalletEntity wallet);
    Task DeleteWalletAsync(WalletEntity wallet);
}
