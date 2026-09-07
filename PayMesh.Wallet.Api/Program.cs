using Microsoft.EntityFrameworkCore;
using PayMesh.Wallet.Api.Data;

var builder = WebApplication.CreateBuilder(args);

var connectionString =
    builder.Configuration.GetConnectionString("WalletDatabase")
    ?? throw new InvalidOperationException(
        "Connection string 'WalletDatabase' was not found.");

builder.Services.AddDbContext<WalletDbContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddScoped<IWalletRepository, WalletRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.Run();
