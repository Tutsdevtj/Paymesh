using PayMesh.Wallet.Api.Entities;

public class WalletService : IWalletService
{
    private readonly IWalletRepository _walletRepository;

    public WalletService(IWalletRepository walletRepository)
    {
        _walletRepository = walletRepository;
    }

    public async Task<WalletEntity> GetWalletByIdAsync(Guid walletId)
    {
        return await _walletRepository.GetWalletByIdAsync(walletId);
    }

    public async Task<IEnumerable<WalletEntity>> GetAllWalletsAsync(int pSkip, int pTake)
    {
        return await _walletRepository.GetAllWalletsAsync(pSkip, pTake);
    }

    public async Task AddWalletAsync(WalletEntity wallet)
    {
        await _walletRepository.AddWalletAsync(wallet);
    }

    public async Task UpdateWalletAsync(WalletEntity wallet)
    {
        await _walletRepository.UpdateWalletAsync(wallet);
    }

    public async Task DeleteWalletAsync(WalletEntity wallet)
    {
        await _walletRepository.DeleteWalletAsync(wallet);
    }
}