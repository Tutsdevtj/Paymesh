using Microsoft.EntityFrameworkCore;
using WalletEntity = PayMesh.Wallet.Api.Entities.WalletEntity;

namespace PayMesh.Wallet.Api.Data;

public class WalletDbContext : DbContext
{
    public WalletDbContext(DbContextOptions<WalletDbContext> options)
        : base(options)
    {
    }

    public DbSet<WalletEntity> Wallets => Set<WalletEntity>();
}