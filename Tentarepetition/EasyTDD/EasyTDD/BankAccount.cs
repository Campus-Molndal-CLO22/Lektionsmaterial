namespace EasyTDD;

// Klassen BankAccount skapar en instans av en bankkonto med en initial balans
public class BankAccount
{
    /// <summary>
    /// Konstruktor för att skapa ett nytt bankkonto med en initial balans
    /// </summary>
    /// <param name="initialBalance">Startbalansen för kontot</param>
    public BankAccount(int initialBalance)
    {
        // Sätt balance till initialbalansen
        Balance = initialBalance;
    }

    /// <summary>
    /// Egenskap för att läsa av kontobalansen
    /// </summary>
    /// <returns>Aktuell kontobalans</returns>
    public int Balance { get; private set; }

    /// <summary>
    /// Metod för att sätta in pengar på kontot
    /// </summary>
    /// <param name="amount">Belopp att sätta in</param>
    public void Deposit(int amount)
    {
        // Lägg till beloppet till kontobalansen
        if (amount>0) Balance += amount;
    }

    /// <summary>
    /// Metod för att ta ut pengar från kontot
    /// </summary>
    /// <param name="amount">Belopp att ta ut</param>
    public void Withdraw(int amount)
    {
        // Subtrahera beloppet från kontobalansen
        if (amount>0 && Balance>=amount) Balance -= amount;
    }
}