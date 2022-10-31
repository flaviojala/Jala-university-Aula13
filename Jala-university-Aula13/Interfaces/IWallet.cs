namespace Jala_university_Aula13.Interfaces;

public interface IWallet
{
    public int Id { get; set; }
    public decimal Balance { get; set; }
    public void AddToBalance(decimal amount);
}