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
        var wallet = await _walletRepository.GetWalletByIdAsync(walletId);

        return wallet
            ?? throw new KeyNotFoundException(
                $"Wallet with ID {walletId} not found.");
    }

    public async Task<IEnumerable<WalletEntity>> GetAllWalletsAsync()
    {
        return await _walletRepository.GetAllWalletsAsync();
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