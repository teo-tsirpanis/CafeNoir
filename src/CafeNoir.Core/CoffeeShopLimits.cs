namespace CafeNoir.Core;

public sealed class CoffeeShopLimits
{
    public uint MinManagers { get; init; } = 1;
    public uint MaxManagers { get; init; } = 1;
    public uint MinCashiers { get; init; } = 1;
    public uint MaxCashiers { get; init; } = 2;
    public uint MinBaristas { get; init; } = 1;
    public uint MaxBaristas { get; init; } = 2;
    public uint MinWaiters { get; init; } = 1;
    public uint MaxWaiters { get; init; } = 3;

    public static CoffeeShopLimits Default { get; } = new();

    public CoffeeShopLimits()
    {
    }
}
