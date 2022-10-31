using Jala_university_Aula13.Interfaces;

namespace Jala_university_Aula13.Models;

public class Wallet : IWallet
{
    public int Id { get; set; }
    public decimal Balance { get; set; }
    public const string WalletCurrency = "BRL";
    public void AddToBalance(decimal amount)
    {
        Balance += amount;
    }
}