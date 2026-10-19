namespace FinanceTracker.Domain;

public class Account
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public decimal Balance { get; set; }
    public DateTime OpeningDate { get; set; }
}