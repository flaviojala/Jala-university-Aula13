using Jala_university_Aula13.Interfaces;

namespace Jala_university_Aula13.Services;

public class WalletService
{
    private readonly ICurrency _currency;
    private readonly IWallet _wallet;

    public WalletService(ICurrency currency, IWallet wallet)
    {
        _currency = currency;
        _wallet = wallet;
    }
    
    public Tuple<string, decimal> ExchangeMoney(string outgoingCurrency, decimal amount)
    {
        if (!_currency.Currencies.TryGetValue(outgoingCurrency,out var to))
        {
            throw new ArgumentException("Invalid currency");
        }

        if (amount < 50)
        {
            throw new InvalidOperationException("amount below expected");
        }

        if (amount > _wallet.Balance)
        {
            throw new ArgumentException();
        }
       
        var total = (amount * to) - 0.01M;
        
        return new Tuple<string, decimal>(outgoingCurrency, total);
    }
    
    public void AddMoneyToWalletService(decimal amount)
    {
       _wallet.AddToBalance(amount);
    }
    
    public decimal GetAvailableMoneyService()
    {
        return _wallet.Balance;
    }
    
}