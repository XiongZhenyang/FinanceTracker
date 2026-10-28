namespace FinanceTracker.Domain;

public class Operation
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public string Type { get; set; }
    public DateTime Date { get; set; }
    public int AccountId { get; set; }
    public int CategoryId { get; set; }
}